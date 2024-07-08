using NoStringEvaluating.Nodes.Base;

namespace NoStringEvaluating.Nodes;

/// <summary>
/// Formula node - Word
/// </summary>
public class WordNode : BaseFormulaNode
{
    /// <summary>
    /// Word
    /// </summary>
    public string Word { get; }

    /// <summary>
    /// Formula node - Word
    /// </summary>
    public WordNode(string word) : base(NodeTypeEnum.Word)
    {
        Word = string.Intern(word);
    }

    /// <summary>
    /// ToString
    /// </summary>
    public override string ToString()
    {
        return Word;
    }
}
