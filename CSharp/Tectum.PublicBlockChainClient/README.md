## Endpoints ##

The Light Node supports the following types of requests:

### TET operations: ###

-   **[GET /coins/balances](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/tet_coin_balance_request.md)**: Retrieve balances for multiple tokens
-   **[POST /coins/transfer](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/tet_transfer_request.md)**: Transfer TET coins from one wallet to another.
-   **[GET /coins/transfers](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/coin_transfer_transactions.md)**: Retrieve TET transfer history
-   GET /coins/transfers/user: Retrieve TET transfer history for user
-   GET /coins/transfers/fee: Retrieve fee for transfer


### Key management: ###

-   **[POST /keys/recover](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/keys_recovery_request.md)**: Recover keys using a seed phrase
-   **[GET /keys/public/byskey](https://github.com/crispmindltd/light_node_tectum/tree/main/docs/public_key_by_skey_request.md)**: Retrieve the public key by session key

### Blocks: ###

-   GET /blockscount: Retrieve count of blocks
