﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EPL
{
    public class Constants
    {
        public static readonly Color[] colors = {
        new Color(253f / 255f, 187f / 255f, 48f / 255f),
        new Color(123f / 255f, 193f / 255f, 67f / 255f),
        new Color(228f / 255f, 14f / 255f, 98f / 255f),
        new Color(124f / 255f, 63f / 255f, 153f / 255f),
        new Color(0f / 255f, 157f / 255f, 220f / 255f),
        new Color(0f / 255f, 75f / 255f, 141f / 255f)
        };

        public static readonly Dictionary<string,Color> EPLColors = new Dictionary<string, Color>{
        { "Yellow", new Color(253f / 255f, 187f / 255f, 48f / 255f) },
        { "Green", new Color(123f / 255f, 193f / 255f, 67f / 255f) },
        { "Pink", new Color(228f / 255f, 14f / 255f, 98f / 255f)},
        { "Purple", new Color(124f / 255f, 63f / 255f, 153f / 255f)},
        { "Blue", new Color(0f / 255f, 157f / 255f, 220f / 255f)},
        { "DarkBlue", new Color(0f / 255f, 75f / 255f, 141f / 255f) }
        };

        public static readonly float PanelWidth = 0.653f;
        public static readonly float PanelHeight = 1.215f;
        public static readonly float ZoneBPlanarHeight = 2.705f; //TODO
        public static readonly float ZoneAProjectorWidth = 5.76f;
        public static readonly float ZoneAPlanarHeight = 4.212f;
        public static readonly float ZoneBProjectorWidth = 4.802f; // TODO
        public static readonly float DevMonitorWidth = 0.894f;
        public static readonly float DevMonitorHeight = 0.473f;
        public static readonly float QUTDevProjectorWidth = 2.744f;
        public static readonly float QUTDevProjectorHeight = 1.3f;
        public static readonly float LCDWidth = 0.576f;
        public static readonly float LCDHeight = 0.36f;//0.324f; // TODO
        public static readonly float ZoneBLedOffset = 0.021f;

        public static readonly Vector2 PanelResolution = new Vector2(1080f, 1920f);
        public static readonly Vector2 PlanarAResolution = new Vector2(3200f, 2340f);

        public static readonly int DevelopmentNumPanels = 3;
        public static readonly int ZoneANumPanels = 18;
        public static readonly int ZoneBNumPanels = 7;
        public static readonly int ZoneANumPlanars = 2;
        public static readonly int ZoneBNumPlanars = 1;
        public static readonly int PanelsPerDisplay = 3;
        public static readonly int DevNumLCDRows = 1;
        public static readonly int DevNumLCDColumns = 2;
        

        public static readonly Vector3 ZoneBSpeaker0 = new Vector3(-1.3704f, 0f, 0f);
        public static readonly Vector3 ZoneBSpeaker1 = new Vector3(1.3704f, 0f, 0f);
        public static readonly Vector3 ZoneBSpeakerCenter = new Vector3(0f, 0f, 0f);
        public static readonly Vector3 ZoneASpeaker0 = new Vector3(-5.139f, 0f, 0f);
        public static readonly Vector3 ZoneASpeaker1 = new Vector3(-3.0834f, 0f, 0f);
        public static readonly Vector3 ZoneASpeaker2 = new Vector3(-1.0278f, 0f, 0f);
        public static readonly Vector3 ZoneASpeaker3 = new Vector3(1.0278f, 0f, 0f);
        public static readonly Vector3 ZoneASpeaker4 = new Vector3(3.0834f, 0f, 0f);
        public static readonly Vector3 ZoneASpeaker5 = new Vector3(5.139f, 0f, 0f);
        public static readonly Vector3 ZoneASpeakerL = new Vector3(-6.1668f, 2.113f, 0f);
        public static readonly Vector3 ZoneASpeakerR = new Vector3(6.1668f, 2.113f, 0f);

        public static readonly Vector2 SpeakerSize = new Vector2(.89524f, .1f);
    }
}