namespace PublisherSubscriberPattern;

// There can be more than one Subscriber to use similar interface
// i.e., we can notify readers via email or a phone app.
public interface ISubscriber
{
    public void Update(IPublisher publisher);
}