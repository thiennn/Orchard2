using Orchard.ContentManagement.MetaData.Models;
using Orchard.DisplayManagement.Handlers;

namespace Orchard.ContentTypes.Editors
{
    public abstract class ContentPartDisplayDriver : DisplayDriver<ContentPartDefinition, BuildDisplayContext, BuildEditorContext, UpdatePartEditorContext>, IContentPartDefinitionDisplayDriver
    {
        public override string GeneratePrefix(ContentPartDefinition model)
        {
            return model.Name;
        }
    }
}