using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Tectum.PublicBlockChainClient.Responses;

namespace Tectum.PublicBlockChainClient;

public abstract class BaseHttpClient
{
    protected readonly HttpClient HttpClient;
    protected readonly JsonSerializerOptions? JsonSerializerOptions;

    protected BaseHttpClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
        JsonSerializerOptions = new JsonSerializerOptions()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.Never,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
        };
    }

    protected BaseHttpClient(HttpClient httpClient, JsonSerializerOptions jsonSerializerOptions)
    {
        HttpClient = httpClient;
        JsonSerializerOptions = jsonSerializerOptions;
    }

    protected async Task<T?> GetAsync<T>(string url,
        IEnumerable<KeyValuePair<string, string>>? parameters = default,
        CancellationToken cancellationToken = default)
        where T : BaseResponse
    {
        NameValueCollection? queryString = null;
        if (parameters != null)
        {
            queryString = HttpUtility.ParseQueryString(string.Empty);
            foreach (var parameter in parameters)
            {
                queryString.Add(parameter.Key, parameter.Value);
            }
        }

        using var requestMessage = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url + (queryString != null ? "?" + queryString : ""), UriKind.Relative)
        };

        var response = await SendRequestAsync(requestMessage, cancellationToken);
        return JsonSerializer.Deserialize<T>(response, JsonSerializerOptions);
    }

    protected Task<T?> SendRequestAsync<T>(string url,
        HttpMethod method,
        object? request = default,
        CancellationToken cancellationToken = default)
        where T : class
    {
        return SendRequestAsync<T>(url, method, new Dictionary<string, string>(), request, cancellationToken);
    }

    /// <summary>
    /// Send request to outside by httlcient
    /// </summary>
    /// <param name="url">Url</param>
    /// <param name="method">http method</param>
    /// <param name="headers">Headers of http client</param>
    /// <param name="request">Request for sending to </param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <typeparam name="T">BaseApiResponse </typeparam>
    /// <returns></returns>
    protected Task<T?> SendRequestAsync<T>(string url,
        HttpMethod method,
        IReadOnlyDictionary<string, string> headers,
        object? request = default,
        CancellationToken cancellationToken = default)
        where T : class
    {
        return SendRequestAsync<T>(url, method, headers, UriKind.Relative, request,
            cancellationToken);
    }

    /// <summary>
    /// Send request to outside by httlcient
    /// </summary>
    /// <param name="url">Url</param>
    /// <param name="method">http method</param>
    /// <param name="headers">Headers of http client</param>
    /// <param name="uriKind">Uri kind</param>
    /// <param name="request">Request for sending to </param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <typeparam name="T">BaseApiResponse </typeparam>
    /// <returns></returns>
    protected async Task<T?> SendRequestAsync<T>(string url,
        HttpMethod method,
        IReadOnlyDictionary<string, string> headers,
        UriKind uriKind,
        object? request = default,
        CancellationToken cancellationToken = default)
        where T : class
    {
        StringContent? content = null;

        if (request != null)
        {
            var jsonRequest = JsonSerializer.Serialize(request, JsonSerializerOptions);

            content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        }

        using (var requestMessage = new HttpRequestMessage())
        {
            requestMessage.Content = content;
            requestMessage.Method = method;
            requestMessage.RequestUri = new Uri(url, uriKind);

            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            var response = await SendRequestAsync(requestMessage, cancellationToken).ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(response, JsonSerializerOptions);
        }
    }

    /// <summary>
    /// Send request to outside services
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken">Token</param>
    private async Task<string> SendRequestAsync(HttpRequestMessage message, CancellationToken cancellationToken)
    {
        using var response = await HttpClient.SendAsync(message, cancellationToken).ConfigureAwait(false);
        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
    }
}