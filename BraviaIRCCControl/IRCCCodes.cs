using System;
using System.Collections.Generic;
using System.Text;

namespace BraviaIRCCControl
{
    public enum IRCCCodes
    {

        [IRCCCodeAttribute("AAAAAQAAAAEAAABlAw==")]
        Confirm,


        [IRCCCodeAttribute("AAAAAQAAAAEAAAB0Aw==")]
        Up,


        [IRCCCodeAttribute("AAAAAQAAAAEAAAB1Aw==")]
        Down,


        [IRCCCodeAttribute("AAAAAQAAAAEAAAAzAw==")]
        Right,


        [IRCCCodeAttribute("AAAAAQAAAAEAAAA0Aw==")]
        Left,


        [IRCCCodeAttribute("AAAAAQAAAAEAAABgAw==")]

        Home,

        [IRCCCodeAttribute("AAAAAgAAAJcAAAA2Aw==")]

        Options,

        [IRCCCodeAttribute("AAAAAgAAAJcAAAAjAw==")]

        Return,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAAAw==")]

        Num1,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAABAw==")]

        Num2,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAACAw==")]

        Num3,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAADAw==")]

        Num4,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAEAw==")]

        Num5,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAFAw==")]

        Num6,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAGAw==")]

        Num7,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAHAw==")]

        Num8,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAIAw==")]

        Num9,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAJAw==")]

        Num0,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAKAw==")]

        Num11,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAALAw==")]

        Num12,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAVAw==")]

        Power,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAA6Aw==")]

        Display,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAASAw==")]

        VolumeUp,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAATAw==")]

        VolumeDown,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAUAw==")]

        Mute,

        [IRCCCodeAttribute("AAAAAQAAAAEAAAAXAw==")]

        Audio,

        [IRCCCodeAttribute("AAAAAgAAAJcAAAAoAw==")]

        SubTitle,

        [IRCCCodeAttribute("AAAAAgAAAJcAAAAnAw==")]

        Yellow,

        [IRCCCodeAttribute("AAAAAgAAAJcAAAAkAw==")]

        Blue,

        [IRCCCodeAttribute("AAAAAgAAAJcAAAAlAw==")]

        Red,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAmAw==")]
        Green,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAaAw==")]
        Play,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAYAw==")]
        Stop,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAZAw==")]
        Pause,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAbAw==")]
        Rewind,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAcAw==")]
        Forward,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAA8Aw==")]
        Prev,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAA9Aw==")]
        Next,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAB5Aw==")]
        Replay,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAB4Aw==")]
        Advance,


        [IRCCCodeAttribute("AAAAAgAAABoAAABgAw==")]
        TopMenu,


        [IRCCCodeAttribute("AAAAAgAAABoAAABhAw==")]
        PopUpMenu,


        [IRCCCodeAttribute("AAAAAgAAAJcAAABIAw==")]
        Eject,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAgAw==")]
        Rec,


        [IRCCCodeAttribute("AAAAAgAAABoAAABYAw==")]
        SyncMenu,


        [IRCCCodeAttribute("AAAAAgAAAKQAAAAQAw==")]
        ClosedCaption,


        [IRCCCodeAttribute("AAAAAQAAAAEAAAA/Aw==")]
        Teletext,


        [IRCCCodeAttribute("AAAAAQAAAAEAAAAQAw==")]
        ChannelUp,


        [IRCCCodeAttribute("AAAAAQAAAAEAAAARAw==")]
        ChannelDown,


        [IRCCCodeAttribute("AAAAAQAAAAEAAAAlAw==")]
        Input,


        [IRCCCodeAttribute("AAAAAQAAAAEAAAAOAw==")]
        GGuide,


        [IRCCCodeAttribute("AAAAAgAAAKQAAABbAw==")]
        EPG,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAdAw==")]
        DOT,


        [IRCCCodeAttribute("AAAAAgAAAHcAAAANAw==")]
        Analog,


        [IRCCCodeAttribute("AAAAAQAAAAEAAABjAw==")]
        Exit,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAyAw==")]
        Digital,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAsAw==")]
        BS,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAArAw==")]
        CS,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAQAw==")]
        BSCS,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAVAw==")]
        Ddata,


        [IRCCCodeAttribute("AAAAAgAAABoAAAB6Aw==")]
        InternetWidgets,


        [IRCCCodeAttribute("AAAAAgAAABoAAAB5Aw==")]
        InternetVideo,


        [IRCCCodeAttribute("AAAAAgAAABoAAAB4Aw==")]
        SceneSelect,


        [IRCCCodeAttribute("AAAAAgAAAHcAAABNAw==")]
        Mode3D,


        [IRCCCodeAttribute("AAAAAgAAABoAAAB7Aw==")]
        iManual,


        [IRCCCodeAttribute("AAAAAgAAAKQAAAA9Aw==")]
        Wide,


        [IRCCCodeAttribute("AAAAAQAAAAEAAAA7Aw==")]
        Jump,


        [IRCCCodeAttribute("AAAAAgAAAKQAAAB3Aw==")]
        PAP,


        [IRCCCodeAttribute("AAAAAgAAAHcAAABrAw==")]
        MyEPG,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAWAw==")]
        ProgramDescription,


        [IRCCCodeAttribute("AAAAAgAAAHcAAABsAw==")]
        WriteChapter,


        [IRCCCodeAttribute("AAAAAgAAABoAAAB+Aw==")]
        TrackID,


        [IRCCCodeAttribute("AAAAAgAAAJcAAAAMAw==")]
        TenKey,

        [IRCCCodeAttribute("AAAAAgAAABoAAABvAw==")]
        AppliCast,



        [IRCCCodeAttribute("AAAAAgAAABoAAAByAw==")]
        acTVila,


        [IRCCCodeAttribute("AAAAAgAAAHcAAAAfAw==")]
        DeleteVideo,


        [IRCCCodeAttribute("AAAAAgAAAHcAAABqAw==")]
        EasyStartUp,


        [IRCCCodeAttribute("AAAAAgAAABoAAABkAw==")]
        OneTouchTimeRec,


        [IRCCCodeAttribute("AAAAAgAAABoAAABlAw==")]
        OneTouchView,


        [IRCCCodeAttribute("AAAAAgAAABoAAABiAw==")]
        OneTouchRec,


        [IRCCCodeAttribute("AAAAAgAAABoAAABjAw==")]
        OneTouchRecStop,


    }
}
