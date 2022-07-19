// See https://aka.ms/new-console-template for more information
using MediatorPattern.ConcreteColleague;
using MediatorPattern.ConcreteMediator;

var chatMediator = new ChatMediator();
var davidUser = new User(1, "David");
var lukaUser = new User(2, "Luka");

// Register in mediator the users
chatMediator.Register(davidUser);
chatMediator.Register(lukaUser);

// Comunication
chatMediator.Send(davidUser, lukaUser, "Hello Luka! How are you?");
chatMediator.Send(lukaUser, davidUser, "Hi David! Good, you?");