using System.Collections.Generic;
using UnityEngine;

public class MaterialUIOptions : MonoBehaviour {
    public Color DefaultColor;
    public Color PrimaryColor;
    public Color LightColor;
    public Color DarkColor;
    public Color PrimaryFontColor;
    public Color LightFontColor;
    public Color DarkFontColor;
    public Color DefaultFontColor;
    public Dictionary<MaterialType, Color> materialTextColorMap = new Dictionary<MaterialType, Color>();
    public Dictionary<MaterialType, Color> materialAccentColorMap = new Dictionary<MaterialType, Color>();

    private void Awake() {
        materialTextColorMap.Add(MaterialType.PRIMARY, PrimaryFontColor);
        materialTextColorMap.Add(MaterialType.LIGHT, LightFontColor);
        materialTextColorMap.Add(MaterialType.DARK, DarkFontColor);
        materialTextColorMap.Add(MaterialType.DEFAULT, DefaultFontColor);

        materialAccentColorMap.Add(MaterialType.PRIMARY, PrimaryColor);
        materialAccentColorMap.Add(MaterialType.LIGHT, LightColor);
        materialAccentColorMap.Add(MaterialType.DARK, DarkColor);
        materialAccentColorMap.Add(MaterialType.DEFAULT, DefaultColor);
    }
}

public enum MaterialType { PRIMARY, LIGHT, DARK, DEFAULT };