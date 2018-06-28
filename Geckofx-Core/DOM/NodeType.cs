namespace Gecko
{
    public enum NodeType
    {
        Element = (int) 1/*nsIDOMNodeConsts.ELEMENT_NODE*/,
        Attribute = (int) 2/*nsIDOMNodeConsts.ATTRIBUTE_NODE*/,
        Text = (int) 3/*nsIDOMNodeConsts.TEXT_NODE*/,
        CDataSection = (int) 4/*nsIDOMNodeConsts.CDATA_SECTION_NODE*/,
        EntityReference = (int) 5/*nsIDOMNodeConsts.ENTITY_REFERENCE_NODE*/,
        Entity = (int) 6/*nsIDOMNodeConsts.ENTITY_NODE*/,
        ProcessingInstruction = (int) 7/*nsIDOMNodeConsts.PROCESSING_INSTRUCTION_NODE*/,
        Comment = (int) 8/*nsIDOMNodeConsts.COMMENT_NODE*/,
        Document = (int) 9/*nsIDOMNodeConsts.DOCUMENT_NODE*/,
        DocumentType = (int) 10/*nsIDOMNodeConsts.DOCUMENT_TYPE_NODE*/,
        DocumentFragment = (int) 11/*nsIDOMNodeConsts.DOCUMENT_FRAGMENT_NODE*/,
        Notation = (int) 12/*nsIDOMNodeConsts.NOTATION_NODE*/
    }
}