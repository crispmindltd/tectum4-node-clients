## Endpoints ##

The Validator Node supports the following types of requests:

### Coin operations: ###

-   **[POST /coins/transfer](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coin_operations/POST_coins_transfer.md)**: To transfer TET between two addresses
-   **[GET /coins/transfer?id=N](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coin_operations/GET_coins_transfers_id.md)**: Retrieve full information of transfer for the TET
-   **[GET /coins/transfers](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coin_operations/GET_coins_transfers.md)**: Retrieve the transfer history for the TET
-   **[POST /coins/stake](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coin_operations/POST_coins_stake.md)**: Staking TET to become a network validator
-   **[POST /coins/migrate](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coin_operations/POST_coins_migrate.md)**: Migrate TET to new address
-   **[GET /coins/balance/byaddress](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coin_operations/GET_coins_balance_byAddress.md)**: Retrieve TET balance by address
-   **[GET /coins/transfers/user](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coin_operations/GET_coins_transfers_user.md)**: Retrieve the TET transfer history for a specific user

### Key management: ###

-   **[GET /keys/new](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/key_management/GET_keys_generate.md)**: Generate a private/public key pair
-   **[POST /keys/recover](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/key_management/POST_keys_recovery.md)**: Recover keys using a seed phrase

### Settings: ###

-   **[GET /version](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/settings/GET_version_request.md)**: View node version

### Blocks: ###

-   **[GET /blockscount](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/blocks/GET_blocks_count.md)**: Retrieve the total count of blocks in the blockchain