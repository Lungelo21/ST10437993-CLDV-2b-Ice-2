using Azure.Data.Tables;
using Azure.Identity;

namespace AzureCosmoDBForTables.Services
{
    public class TableServiceClient : TableClient
    {
        DefaultAzureCredential credential = new();

        TableServiceClient serviceClient = new(
            endpoint: new Uri("<azure-cosmos-db-table-account-endpoint>"),
            credential
        );

        public async Task<string> GetTableClient(string tableName)
        {
            TableClient client = serviceClient.GetTableClient(
                        tableName: "<azure-cosmos-db-table-name>"
                    );
        }
    }
}
