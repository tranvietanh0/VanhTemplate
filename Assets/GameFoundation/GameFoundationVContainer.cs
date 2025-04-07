#nullable enable
namespace GameFoundation.Scripts
{
    using GameFoundation.Scripts.AssetLibrary;
    using UnityEngine;
    using VContainer;
    using VContainer.Unity;

    public static class GameFoundationVContainer
    {
        public static void RegisterGameFoundation(this IContainerBuilder builder, Transform rootTransform)
        {
            builder.Register<GameAssets>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}