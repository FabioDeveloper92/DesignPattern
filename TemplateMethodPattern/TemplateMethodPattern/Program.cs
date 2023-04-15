using TemplateMethodPattern.AbstractClass;
using TemplateMethodPattern.ConcreteClass;

Game football = new FootBall();
football.Play();

Console.WriteLine();
Console.WriteLine();

Game basketball = new Basketball();
basketball.Play();