﻿using Gley.UrbanSystem.Editor;
using UnityEngine;

namespace Gley.TrafficSystem.Editor
{
    internal class ShowComplexGiveWayWaypoints : ShowWaypointsTrafficBase
    {
        private readonly float _scrollAdjustment = 221;

        internal override SetupWindowBase Initialize(WindowProperties windowProperties, SettingsWindowBase window)
        {
            base.Initialize(windowProperties, window);
            _waypointsOfInterest = _trafficWaypointData.GetComplexGiveWayWaypoints();
            return this;
        }

        internal override void DrawInScene()
        {
            _trafficWaypointDrawer.ShowComplexGiveWayWaypoints(_editorSave.EditorColors.WaypointColor);
            base.DrawInScene();
        }


        protected override void ScrollPart(float width, float height)
        {
            _scrollPosition = GUILayout.BeginScrollView(_scrollPosition, false, false, GUILayout.Width(width - SCROLL_SPACE), GUILayout.Height(height - _scrollAdjustment));
            base.ScrollPart(width, height);
            GUILayout.EndScrollView();
        }
    }
}