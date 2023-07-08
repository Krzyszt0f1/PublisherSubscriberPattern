namespace PublisherSubscriberPattern;

public class EmailNewsLetter : ISubscriber
{
    public void Update(IPublisher publisher)
    {
        Console.WriteLine($"Received an Email with the latest article: {(publisher as Gazette).LatestArticle}");
    }
}