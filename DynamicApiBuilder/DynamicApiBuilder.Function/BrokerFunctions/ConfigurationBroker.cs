using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Kafka;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using DynamicApiBuilder.Infrestructure.Entity;

namespace DynamicApiBuilder.Function.BrokerFunctions
{
    public class ConfigurationBroker
    {
        [FunctionName("KafkaConfigurationBroker")]
        public async Task Run([KafkaTrigger("localhost:9092", "configuration-broker-queue", ConsumerGroup = "$Default")] 
        KafkaEventData<DefaultRequest> kafkaEventData,
        ILogger log)
        {
            
        }
    }
}
