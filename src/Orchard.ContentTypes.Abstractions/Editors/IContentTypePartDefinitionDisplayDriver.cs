using Orchard.ContentManagement.MetaData.Models;
using Orchard.DependencyInjection;
using Orchard.DisplayManagement.Handlers;

namespace Orchard.ContentTypes.Editors
{
    public interface IContentTypePartDefinitionDisplayDriver : IDisplayDriver<ContentTypePartDefinition, BuildDisplayContext, BuildEditorContext, UpdateTypePartEditorContext>, IDependency
    {
    }
}