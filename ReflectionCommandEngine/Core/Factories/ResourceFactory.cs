namespace Empires.Core.Factories
{
    using System;
    using Contracts;
    using Models;

    public class ResourceFactory : IResourceFactory
    {
        public IResource CreateReource(string resourceTypeName, int quantity)
        {
            ResourceType resourceType =
                (ResourceType)Enum.Parse(typeof(ResourceType), resourceTypeName);

            var resource = new Resources(resourceType, quantity);

            return resource;
        }
    }
}