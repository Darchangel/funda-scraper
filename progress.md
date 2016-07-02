#Funda Scraper: Progress

Here I hope to be able to write some notes about my progress in this project. Ideally it will become a blog post at some point, in
some place.

##Idea
(2016-06-30)
The idea came to me after seeing how frustrating it is to search for houses in the Netherlands (especially in highly-sought places
like Utrecht), and keep up to date with the new listings.
The purpose of this project is twofold:

1) Allow me to semi-automate the house search by having an program look through listings for me and searching for important
criteria (price, nr. of rooms, location, etc). When meaningful results are found, the program should send me some kind of
notification, and optionally provide a web interface for seeing the found results.

2) Give me a complex-enough, distributable project for me to try working with different technologies and techniques, for instance:
    * Various windows Azure services
    * Containers
    * Functional programming (using F#)
    * Event-driven development
    * Programming using the Actor model
    * Web scraping (somehow, I never got to it)
    * Blogging about a project. I like to write, but I never really tried to write about something I _did_.


## Research
First of all, I need to decide what to work with. F# is certain, since I've been trying to use it somewhere for ages. I'll deploy
whatever comes out of this on Azure, using containers, since it's something I want to know more about (and a certain job interview
made me realize I never had any real contact with them).

As a first stab of some sort of things to use, the main idea is:
- Use F#.
- Use Docker in Azure to deploy services
- Split up the services as much as possible and glue them using events. I need to research what tools exist to help with
event-driven development.
    - May be too split, artificially so, but will give a solid base to try the distribution/orchestration aspects of the
    containers
- Use the Actor model to program. I find it interesting, and know people that can help. There are helper libraries I can use like Akka.NET
or Cricket.
- Maybe use TDD to develop? Being that this is very exploratory for me, I'm not sure how well this will work.
- Use something like Application Insights (or Datadog, if it has a free account tier) to publish metrics about the components and
the system itself
- Some components may end up being:
    - Scheduled job to regularly scrape the site
    - Event source (?)
    - Configuration service (publishes events when configs change)
    - Search criteria filter
    - Notifier (sends notifications when a matching site is foun)
    - API for access to the found results
    - Web page
    - Mobile app w/ push notifications?


I will keep writing here, in one form or another.


## (2016-07-02) Starting small
No use to research too much about a lot before actually doing something. So I will start with writing a small program to
scrape a page. It will give me a chance to start trying out the Actor model, f# and a scraping library.
