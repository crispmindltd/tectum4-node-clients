## Endpoints ##

The Light Node supports the following types of requests:

### Token operations: ###

-   GET /tokens: Retrieve a list of all tokens
-   **[POST /tokens](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/create_token_request.md)**: Create a new token
-   GET /tokens/fee: Retrieve fee of creating token
-   GET /tokens/ticker: Retrieve information about a specific token
-   **[POST /tokens/transfer](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/create_token_request.md)**: To transfer tokens between two addresses
-   GET /tokens/transfer/fee: Retrieve fee of token transfer
-   GET /tokens/transfers: Retrieve token transfer history
-   **[GET /tokens/address/byid](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/smart_contract_address_request.md)**: Retrieve the smart contract address by ID
-   **[GET /tokens/address/byticker](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/smart_contract_address_ticker_request.md)**: Retrieve the smart contract address by ticker
-   **[GET /tokens/balance/byaddress](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/token_balance_request.md)**: Retrieve token balance by address
-   **[GET /tokens/balance/byticker](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/token_balance_ticker_request.md)**: Retrieve token balance by ticker

### TET operations: ###

-   **[GET /coins/balances](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/tet_coin_balance_request.md)**: Retrieve balances for multiple tokens
-   **[POST /coins/transfer](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/tet_transfer_request.md)**: Transfer TET coins from one wallet to another.
-   **[GET /coins/transfers](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/coin_transfer_transactions.md)**: Retrieve TET transfer history
-   GET /coins/transfers/user: Retrieve TET transfer history for user
-   GET /coins/transfers/fee: Retrieve fee for transfer

### User management: ###

-   **[POST /user/auth](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/user_authentication_request.md)**: Authenticate an existing user with their login and password
-   **[POST /user/registration](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/user_registration_request.md)**: To register a new user in the system.

### Key management: ###

-   **[POST /keys/recover](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/keys_recovery_request.md)**: Recover keys using a seed phrase
-   **[GET /keys/public/byuserid](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/public_key_by_userid_request.md)**: Retrieve the public key by user ID
-   **[GET /keys/public/byskey](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/public_key_by_skey_request.md)**: Retrieve the public key by session key

### Blocks: ###

-   GET /blockscount: Retrieve count of blocks
