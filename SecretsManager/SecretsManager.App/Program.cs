using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;

var secretsManagerCliente = new AmazonSecretsManagerClient();

var listSecretVersionsRequest = new ListSecretVersionIdsRequest
{
    SecretId = "ApiKey",
    IncludeDeprecated = true
};
var listSecretVersionsResponse = await secretsManagerCliente.ListSecretVersionIdsAsync(listSecretVersionsRequest);

var getSecretValueRequest = new GetSecretValueRequest
{
    SecretId = "ApiKey"
};
var getSecretValueResponse = await secretsManagerCliente.GetSecretValueAsync(getSecretValueRequest);

Console.WriteLine(getSecretValueResponse.SecretString);

var describeSecretRequest = new DescribeSecretRequest
{
    SecretId = "ApiKey"
};

var describeResponse = await secretsManagerCliente.DescribeSecretAsync(describeSecretRequest);