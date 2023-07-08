namespace PublisherSubscriberPattern;

public class Gazette : IPublisher
{
    // For simplicity, state example is onl stored as string.
    public string LatestArticle { get; private set; } = "Breaking News!: 42 is the answer.";

    private List<ISubscriber> _subscribers = new();
    
    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    // Logic to notify subscribers (readers)
    public void Notify()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(this);
        }
    }

    // Simple business logic; in reality it would be much more involved.
    // In this example, it also notifies about the newly published article right away.
    public void PublishNewLatestArticle(string article)
    {
        LatestArticle = article;
        Notify();
    }
}