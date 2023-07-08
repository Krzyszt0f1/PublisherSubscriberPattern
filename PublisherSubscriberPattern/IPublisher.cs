namespace PublisherSubscriberPattern;

// There can be more than one Publisher to use similar interface
// i.e., there are more than one news paper.
public interface IPublisher
{
    void Subscribe(ISubscriber subscriber);

    void Unsubscribe(ISubscriber subscriber);

    void Notify();
}