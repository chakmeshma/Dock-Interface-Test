using Battlehub.UIControls.DockPanels;
using UnityEngine;
using UnityEngine.UI;

public class GettingStarted : MonoBehaviour
{
    DockPanel m_dockPanel;

    void Start()
    {
        m_dockPanel = GetComponent<DockPanel>();

        GameObject testContent = new GameObject();
        testContent.AddComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f, 1.0f);

        LayoutInfo layout = new LayoutInfo(false,
            new LayoutInfo(testContent.transform, "Tab 1"),
                new LayoutInfo(
                    isVertical: true,
                        child0: new LayoutInfo(Instantiate(testContent).transform, "Tab 2"),
                        child1: new LayoutInfo(Instantiate(testContent).transform, "Tab 3"),
                        ratio: 0.5f),
                0.5f);

        m_dockPanel.RootRegion.Build(layout);
    }
}
