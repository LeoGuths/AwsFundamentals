using System.Text.Json;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using SnsPublisher;

var customer = new CustomerCreated
{
    Id = Guid.NewGuid(),
    Email = "leonardoguths@gmail.com",
    FullName = "Leonardo Vinicius Guths",
    DateOfBirth = new DateTime(1995, 5, 17),
    GitHubUsername = "Zehtaly"
};

var snsCliente = new AmazonSimpleNotificationServiceClient();

var topicArnResponse = await snsCliente.FindTopicAsync("customers");

var publishRequest = new PublishRequest
{
    TopicArn = topicArnResponse.TopicArn,
    Message = JsonSerializer.Serialize(customer),
    MessageAttributes = new Dictionary<string, MessageAttributeValue>
    {
        {
            "MessageType", new MessageAttributeValue
            {
                DataType = "String",
                StringValue = nameof(CustomerCreated)
            }
        }
    }
};

var response = await snsCliente.PublishAsync(publishRequest);