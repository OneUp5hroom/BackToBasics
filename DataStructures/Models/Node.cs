using Microsoft.AspNetCore.Components;

namespace DataStructures.Models;

public class Node
{
    public Guid Id { get; set; }
    public int Value { get; set; }
    public bool LineRendered {get; set;} = false;
    public Node ?ParentNode { get; set; }
    public Node ?ChildLeft { get; set; }
    public Node ?ChildRight { get; set; }
    public ElementReference Element { get; set; } = new ElementReference();
    public ElementPostion Position { get; set; } = new ElementPostion();

    public Node (int value, ElementPostion? position = null, Node? parentNode = null, Node? childLeft = null, Node? childRight = null)
    {
        Id = new Guid();
        if (value <= 0)
        {
            throw new Exception("value must be a positive number greater than 0");
        }
        Value = value;
        ParentNode = parentNode;
        ChildLeft = childLeft;
        ChildRight = childRight;
        Element = new ElementReference("ER-" + Id);
        Position = position ?? new ElementPostion();
    }
}