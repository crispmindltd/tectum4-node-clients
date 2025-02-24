## Endpoints ##

The Validator Node supports the following types of requests:

### Coins operations: ###

-   **[POST /coins/transfer](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coins_transfer_request.md)**: To transfer tokens between two addresses (`IPublicBlockChainClient.CreateCoinTransferAsync`) 
-   **[GET /coins/balance/byaddress](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/token_balance_request.md)**: Retrieve TET balance by address (`IPublicBlockChainClient.GetCoinBalancesAsync`)
-   **[GET /coins/transfers](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/token_transfer_history.md)**: Retrieve the transfer history for the TET (`IPublicBlockChainClient.GetCoinTransfersAsync`)
-   **[GET /coins/transfers/user](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/tet_transfer_history_user.md)**: Retrieve the TET transfer history for a specific user (`IPublicBlockChainClient.GetCoinTransfersUserAsync`)
-   **POST /coins/migrate**: Migrate TET to new address (`IPublicBlockChainClient.CreateCoinMigrateAsync`)

### Key management: ###

-   **[GET /keys/new](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/keys_generate_request.md)**: Generate a private/public key pair
-   **[POST /keys/recover](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/keys_recovery_request.md)**: Recover keys using a seed phrase

### Settings: ###

-   **[GET /version](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/version_request.md)**: View node version

### Blocks: ###

-   GET /blockscount: Retrieve count of blocks

