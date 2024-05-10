using System.ComponentModel;

namespace DataStructures.Models;

public class Tree
{
    private bool _firstNode = true;
    private Node? _prevNode = null;
    public Node[] TreeNodes { get; set; } = Array.Empty<Node>();
    public ScreenSize CanvasSize { get; set; } = new ScreenSize();

    public void Add(int value)
    {
        var hOffset = 0;
        var vOffset = 0;
        var pos = new ElementPostion(CanvasSize.V_Center + 100, CanvasSize.H_Center);
        Node node = new Node(value, pos);
        if(_firstNode)
        {
            TreeNodes = TreeNodes.Append(node).ToArray();
            _firstNode = false;
            _prevNode = node;
            return;
        }

        if (TreeNodes.Length % 2 == 0)
        {
            hOffset = -200;
            vOffset = -100;
        }

        if (_prevNode != null && _prevNode.Position != null)
        {
            pos = new ElementPostion(_prevNode.Position.Top + (100 + vOffset), _prevNode.Position.Left + (100 + hOffset));
            node.Position = pos;
        }
        node.ParentNode = _prevNode;
        
        //TODO: find out if we need to get the array member to set child properties on parent or if _prevNode is a pointer
        TreeNodes = TreeNodes.Append(node).ToArray();
        _prevNode = node;
        return;
    }
}