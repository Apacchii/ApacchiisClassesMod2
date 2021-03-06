using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ApacchiisClassesMod2.Configs
{
    [Label("Client Config")]
    public class ACMConfigClient : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        public static ACMConfigClient cInstance;

        [Header("General")]

        [Slider]
        [DefaultValue(0.83f)]
        [Increment(0.01f)]
        [Range(0.25f, 1f)]
        [Label("Healing HUD Offset")]
        [Tooltip("Change this to adjust the left alignment of the 'Health To Regen' HUD to fit your resolution\n" +
                 "[Some example resolutions and their recommended values]\n" +
                 "(1920x1080) = 0.83\n" +
                 "(1600x900) = 0.78\n" +
                 "(1360x768) = 0.75\n" +
                 "(1280x720) = 0.73\n" +
                 "(1024x768) = 0.65")]
        public float HealingHUDOffset { get; set; }

        //[Slider]
        //[DefaultValue(0.83f)]
        //[Increment(0.01f)]
        //[Range(0f, 1f)]
        //[Label("Ability HUD Horizontal Offset")]
        //[Tooltip("Change this to adjust the horizontal alignment of the Abilities HUD")]
        //public float HUDOffsetHorizontal { get; set; }
        
        //[Slider]
        //[DefaultValue(0.83f)]
        //[Increment(0.01f)]
        //[Range(0f, 1f)]
        //[Label("Ability HUD Vertical Offset")]
        //[Tooltip("Change this to adjust the vertical alignment of the Abilities HUD")]
        //public float HUDOffsetVertical { get; set; }
    }
}
