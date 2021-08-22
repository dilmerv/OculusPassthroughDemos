using DilmerGames.Core.Singletons;
using UnityEngine;

public class SurfaceProjectionManager : Singleton<SurfaceProjectionManager>
{
    [SerializeField]
    private OVRPassthroughLayer passthroughLayer;

    [SerializeField]
    private Transform tilesRoot;

    public OVRPassthroughLayer PassthroughLayer => passthroughLayer;

    public Transform TilesRoot => tilesRoot;

    // default is user defined
    private bool reconstructedPassthrough = true;

    public void ShuffleTiles()
    {
        var tiles = tilesRoot.GetComponentsInChildren<SurfacePassthroughTile>();

        foreach (var tile in tiles)
        {
            tile.RandomToggle();
        }
    }

    public void Update()
    {
        // A button
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Logger.Instance.LogInfo("Shuffle tiles executed");
            ShuffleTiles();
        }

        // B button
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            reconstructedPassthrough = !reconstructedPassthrough;

            if(reconstructedPassthrough)
            {
                passthroughLayer.projectionSurfaceType = OVRPassthroughLayer.ProjectionSurfaceType.Reconstructed;
                Logger.Instance.LogInfo("Toggle passthrough set to reconstructed");
            }
            else
            {
                passthroughLayer.projectionSurfaceType = OVRPassthroughLayer.ProjectionSurfaceType.UserDefined;
                Logger.Instance.LogInfo("Toggle passthrough set to user defined");
            }
        }
    }
}
