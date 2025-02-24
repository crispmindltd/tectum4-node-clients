## Endpoints ##

The Validator Node supports the following types of requests:

### Coins operations: ###

-   **[POST /coins/transfer](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coins_transfer_request.md)**: To transfer coins between two addresses
-   **[POST /coins/stake](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coins_stake_request.md)**: Staking tokens to become a network validator
-   **[POST /coins/migrate](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/coins_migrate_request.md)**: To migrate coins to new address

### Key management: ###

-   **[GET /keys/new](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/keys_generate_request.md)**: Generate a private/public key pair
-   **[POST /keys/recover](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/keys_recovery_request.md)**: Recover keys using a seed phrase

### Settings: ###

-   **[GET /version](https://github.com/crispmindltd/tectum4-node-validator/tree/main/docs/version_request.md)**: View node version

### Blocks: ###

-   GET /blockscount: Retrieve count of blocks

