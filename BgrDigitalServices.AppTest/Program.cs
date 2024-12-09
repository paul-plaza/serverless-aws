// See https://aka.ms/new-console-template for more information

using BgrDigitalServices.AWS;

Console.WriteLine("Hello, World!");


EventBusSns eventBus = new EventBusSns();

await eventBus.PublishTopic("verifica-datos-usuario-topic", "Hola mundo soy paul");