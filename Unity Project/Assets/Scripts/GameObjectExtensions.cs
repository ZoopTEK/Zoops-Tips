using System;
using UnityEngine;

/// <summary>
/// Extension methods for game objects.
/// </summary>
public static class GameObjectExtensions
{
    /// <summary>
    /// Gets the existing component if it exists, otherwise adds the component.
    /// </summary>
    /// <typeparam name="T">Component type sought.</typeparam>
    /// <param name="gameObject">The game object to get or add the component upon.</param>
    /// <returns>The existing component, or added component of the given type.</returns>
    /// <exception cref="ObjectDisposedException">gameObject</exception>
    public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
    {
        if (gameObject == null) //ensure game object not null.
            throw new ObjectDisposedException(nameof(gameObject));

        if (gameObject.TryGetComponent(out T component)) //try to get the component
        {
            return component; //found it!  Return it now!
        }

        return gameObject.AddComponent<T>(); //Add a new component.
    }
}