namespace PublisherSubscriberPattern;

public class AppNotification : ISubscriber
{
    public void Update(IPublisher publisher)
    {
        Console.WriteLine($"Received an app notification with the latest article: {(publisher as Gazette).LatestArticle}");
    }
}