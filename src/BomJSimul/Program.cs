﻿namespace BomJSimul
{
    using System;
    using System.Reflection;
    using BomJSimul.Engine;
    using BomJSimul.Render;
    using Catel.IoC;
    using Terminal.Gui;

    public class Program
    {
        private static void Main(string[] args)
        {
            CompositionRoot.Initialize();
            var t = new BomJSimul.GameLogic.PlayerOpenContainerInteraction();
            Console.WriteLine(t.GetRandomItem());
            // Start game loop
            var mainLoop = new GameLoop();

            var serviceLocator = ServiceLocator.Default;
            var renderer = serviceLocator.ResolveType<IConsoleService>();
            renderer.InitializeAndShowMainScreen();
        }
    }
}
