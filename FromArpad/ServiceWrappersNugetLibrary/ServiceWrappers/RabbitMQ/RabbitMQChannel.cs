using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Exceptions;

namespace ServiceWrappers.RabbitMQ
{
    public class RabbitMqChannel
    {
        public IConnection Connection;
        public IModel Channel;
        public RabbitMqChannel(Uri brokerUri = null)
        {
            brokerUri = brokerUri?? new Uri("amqp://guest:guest@localhost:5672");
            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = brokerUri;
            Connection = factory.CreateConnection();
            Channel = Connection.CreateModel();
        }

        public void Close()
        {
            Channel.Close();
            Connection.Close();
        }

        public void ExchangeDeclare(string exchangeName, string exchangeType)
        {
            Channel.ExchangeDeclare(exchangeName, exchangeType);
        }

        public void ExchangeDelete(string exchangeName)
        {
            Channel.ExchangeDelete(exchangeName);
        }

        public void QueueDeclare(string queueName)
        {
            Channel.QueueDeclare(queueName, true, false, false, null);
        }

        public void QueueDelete(string queueName)
        {
            Channel.QueueDelete(queueName);
        }

        public void BindingDeclare(string queueName, string exchangeName, string routingKey)
        {
            Channel.QueueBind(queueName, exchangeName, routingKey);
        }

        public void BasicPublish(string exchangeName, string routingKey, string message)
        {
            Channel.BasicPublish(exchangeName, routingKey, null, System.Text.Encoding.UTF8.GetBytes(message));
        }

        public string BasicGet(string queueName)
        {
            BasicGetResult result =Channel.BasicGet(queueName, true);
            if (result != null)
            {
                return System.Text.Encoding.UTF8.GetString(result.Body);
            }
            else
            {
                return String.Empty;
            }
        }
    }
}
