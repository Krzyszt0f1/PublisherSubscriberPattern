using PublisherSubscriberPattern;

// Creating instance of our Gazette (Publisher).
var theMoon = new Gazette();

// Creating instances of our Subscribers.
var alice = new AppNotification();
var bob = new EmailNewsLetter();

// Subscribing subscribers to `The Moon`.
theMoon.Subscribe(alice);
theMoon.Subscribe(bob);

// Getting the Gazette to notify them about the Latest News Article.
theMoon.Notify();
Console.WriteLine("\n");

// Publishing (and notifying) new `The Moon`'s article.
theMoon.PublishNewLatestArticle("Opinion: Ducks, aliens in disguise");
Console.WriteLine("\n");

// Alice realises that `The Moon` is a cheap tabloid and Unsubscribes.
theMoon.Unsubscribe(alice);

// `The Moon` continues to entertain its readers with `interesting` reads.
// by publishing new articles
theMoon.PublishNewLatestArticle("Finance: Nuke Cola caps sudden price drop!");