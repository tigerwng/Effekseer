﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Effekseer.Data
{
    public enum RecordingExporterType : int
    {
        Sprite,
        SpriteSheet,
        Gif,
        Avi,
    }

    public enum RecordingTransparentMethodType : int
    {
        None,
        Original,
        GenerateAlpha,
    }

	public enum RecordingStorageTargetTyoe : int
	{
		Global,
		Local,
	}
    public enum ParentEffectType : int
	{
		[Key(key = "BasicSettings_ParentEffectType_NotBind")]
		NotBind = 0,
		[Key(key = "BasicSettings_ParentEffectType_NotBind_Root")]
		NotBind_Root = 3,
		[Key(key = "BasicSettings_ParentEffectType_WhenCreating")]
		WhenCreating = 1,
		[Key(key = "BasicSettings_ParentEffectType_Already")]
		Already = 2,
	}

	public enum TranslationParentEffectType : int
	{
		[Key(key = "BasicSettings_ParentEffectType_NotBind")]
		NotBind = 0,
		[Key(key = "BasicSettings_ParentEffectType_NotBind_Root")]
		NotBind_Root = 3,
		[Key(key = "BasicSettings_ParentEffectType_WhenCreating")]
		WhenCreating = 1,
		[Key(key = "BasicSettings_ParentEffectType_Already")]
		Already = 2,
		[Key(key = "BasicSettings_TranslationParentEffectType_NotBind_FollowParent")]
		NotBind_FollowParent = 4,
		[Key(key = "BasicSettings_TranslationParentEffectType_WhenCreating_FollowParent")]
		WhenCreating_FollowParent = 5,
	}

	public enum AlphaBlendType : int
	{
		[Key(key = "AlphaBlendType_Opacity")]
		Opacity = 0,
		[Key(key = "AlphaBlendType_Blend")]
		Blend = 1,
		[Key(key = "AlphaBlendType_Add")]
		Add = 2,
		[Key(key = "AlphaBlendType_Sub")]
		Sub = 3,
		[Key(key = "AlphaBlendType_Mul")]
		Mul = 4,
	}

	public enum RenderingOrder : int
	{
		[Key(key = "RS_RenderingOrder_FirstCreatedInstanceIsFirst")]
		FirstCreatedInstanceIsFirst = 0,
		[Key(key = "RS_RenderingOrder_FirstCreatedInstanceIsLast")]
		FirstCreatedInstanceIsLast = 1,
	}

	public enum CullingValues : int
	{
		[Name(value = "表表示", language = Language.Japanese)]
		[Name(value = "Front view", language = Language.English)]
		Front = 0,
		[Name(value = "裏表示", language = Language.Japanese)]
		[Name(value = "Back view", language = Language.English)]
		Back = 1,
		[Name(value = "両面表示", language = Language.Japanese)]
		[Name(value = "Double-sided", language = Language.English)]
		Double = 2,
	}

	public enum EasingType : int
	{
		[Key(key = "Easing_LeftRightSpeed")]
		LeftRightSpeed = 0,

		[Key(key = "Easing_Linear")]
		Linear = 1,

		[Key(key = "Easing_EaseInQuadratic")]
		EaseInQuadratic = 10,

		[Key(key = "Easing_EaseOutQuadratic")]
		EaseOutQuadratic = 11,

		[Key(key = "Easing_EaseInOutQuadratic")]
		EaseInOutQuadratic = 12,

		[Key(key = "Easing_EaseInCubic")]
		EaseInCubic = 20,

		[Key(key = "Easing_EaseOutCubic")]
		EaseOutCubic = 21,

		[Key(key = "Easing_EaseInOutCubic")]
		EaseInOutCubic = 22,

		[Key(key = "Easing_EaseInQuartic")]
		EaseInQuartic = 30,

		[Key(key = "Easing_EaseOutQuartic")]
		EaseOutQuartic = 31,

		[Key(key = "Easing_EaseInOutQuartic")]
		EaseInOutQuartic = 32,

		[Key(key = "Easing_EaseInQuintic")]
		EaseInQuintic = 40,

		[Key(key = "Easing_EaseOutQuintic")]
		EaseOutQuintic = 41,

		[Key(key = "Easing_EaseInOutQuintic")]
		EaseInOutQuintic = 42,

		[Key(key = "Easing_EaseInBack")]
		EaseInBack = 50,

		[Key(key = "Easing_EaseOutBack")]
		EaseOutBack = 51,

		[Key(key = "Easing_EaseInOutBack")]
		EaseInOutBack = 52,

		[Key(key = "Easing_EaseInBounce")]
		EaseInBounce = 60,

		[Key(key = "Easing_EaseOutBounce")]
		EaseOutBounce = 61,

		[Key(key = "Easing_EaseInOutBounce")]
		EaseInOutBounce = 62,
	}

	public enum EasingStart : int
	{
		[Key(key = "Easing_StartSlowly3")]
		StartSlowly3 = -30,
		[Key(key = "Easing_StartSlowly2")]
		StartSlowly2 = -20,
		[Key(key = "Easing_StartSlowly1")]
		StartSlowly1 = -10,
		[Key(key = "Easing_StartNormal")]
		Start = 0,
		[Key(key = "Easing_StartRapidly1")]
		StartRapidly1 = 10,
		[Key(key = "Easing_StartRapidly2")]
		StartRapidly2 = 20,
		[Key(key = "Easing_StartRapidly3")]
		StartRapidly3 = 30,
	}

	public enum EasingEnd : int
	{
		[Key(key = "Easing_EndSlowly3")]
		EndSlowly3 = -30,
		[Key(key = "Easing_EndSlowly2")]
		EndSlowly2 = -20,
		[Key(key = "Easing_EndSlowly1")]
		EndSlowly1 = -10,
		[Key(key = "Easing_EndNormal")]
		End = 0,
		[Key(key = "Easing_EndRapidly1")]
		EndRapidly1 = 10,
		[Key(key = "Easing_EndRapidly2")]
		EndRapidly2 = 20,
		[Key(key = "Easing_EndRapidly3")]
		EndRapidly3 = 30,
	}

	public enum DrawnAs : int
	{ 
		MaxAndMin,
		CenterAndAmplitude,
	}
	
	public enum ColorSpace : int
	{ 
		RGBA,
		HSVA,
	}

	public enum StandardColorType : int
	{
		[Key(key = "StandardColorType_Fixed")]
		Fixed = 0,
		[Key(key = "StandardColorType_Random")]
		Random = 1,
		[Key(key = "StandardColorType_Easing")]
		Easing = 2,
		[Key(key = "StandardColorType_FCurve")]
		FCurve = 3,
	}

	public enum TrackSizeType : int
	{
		[Name(value = "固定", language = Language.Japanese)]
		[Name(value = "Fixed", language = Language.English)]
		Fixed = 0,
	}

	public class ColorEasingParamater
	{
		[Key(key = "Easing_Start")]
		public Value.ColorWithRandom Start
		{
			get;
			private set;
		}

		[Key(key = "Easing_End")]
		public Value.ColorWithRandom End
		{
			get;
			private set;
		}

		[Key(key = "Easing_StartSpeed")]
		public Value.Enum<EasingStart> StartSpeed
		{
			get;
			private set;
		}

		[Key(key = "Easing_EndSpeed")]
		public Value.Enum<EasingEnd> EndSpeed
		{
			get;
			private set;
		}

		internal ColorEasingParamater()
		{
			Start = new Value.ColorWithRandom(255, 255, 255, 255);
			End = new Value.ColorWithRandom(255, 255, 255, 255);
			Start.Link = End;
			End.Link = Start;
			StartSpeed = new Value.Enum<EasingStart>(EasingStart.Start);
			EndSpeed = new Value.Enum<EasingEnd>(EasingEnd.End);
		}
	}

	public class ColorFCurveParameter
	{
		[Key(key = "FCurve")]
		[Shown(Shown = true)]
		public Value.FCurveColorRGBA FCurve
		{
			get;
			private set;
		}

		internal ColorFCurveParameter()
		{
			FCurve = new Value.FCurveColorRGBA();

			FCurve.R.DefaultValueRangeMax = 256.0f;
			FCurve.R.DefaultValueRangeMin = 0.0f;
			FCurve.G.DefaultValueRangeMax = 256.0f;
			FCurve.G.DefaultValueRangeMin = 0.0f;
			FCurve.B.DefaultValueRangeMax = 256.0f;
			FCurve.B.DefaultValueRangeMin = 0.0f;
			FCurve.A.DefaultValueRangeMax = 256.0f;
			FCurve.A.DefaultValueRangeMin = 0.0f;
		}
	}

	public class FloatEasingParamater
	{
		const int EasingTypeGroup = 200;
		const int MiddlePoint = 300;
		const int RandomGroup = 400;
		const int IndividualType = 500;

		[Key(key = "Easing_Start")]
		public Value.FloatWithRandom Start
		{
			get;
			private set;
		}

		[Key(key = "Easing_End")]
		public Value.FloatWithRandom End
		{
			get;
			private set;
		}

		[Key(key = "Easing_TYpe")]
		[Selector(ID = EasingTypeGroup)]
		public Value.Enum<EasingType> Type
		{
			get;
			private set;
		}

		[Key(key = "Easing_StartSpeed")]
		[Selected(ID = EasingTypeGroup, Value = (int)EasingType.LeftRightSpeed)]
		public Value.Enum<EasingStart> StartSpeed
		{
			get;
			private set;
		}

		[Key(key = "Easing_EndSpeed")]
		[Selected(ID = EasingTypeGroup, Value = (int)EasingType.LeftRightSpeed)]
		public Value.Enum<EasingEnd> EndSpeed
		{
			get;
			private set;
		}

		[Selector(ID = MiddlePoint)]
		[Key(key = "Easing_IsMiddleEnabled")]
		public Value.Boolean IsMiddleEnabled { get; private set; }

		[Selected(ID = MiddlePoint, Value = 0)]
		[Key(key = "Easing_Middle")]
		public Value.FloatWithRandom Middle
		{
			get;
			private set;
		}

		[Key(key = "Easing_IsRandomGroupEnabled")]
		[Selector(ID = RandomGroup)]

		public Value.Boolean IsRandomGroupEnabled { get; private set; }

		/// <summary>
		/// 1.6 or later
		/// </summary>
		[Key(key = "Easing_RandomGroup_A")]
		[Selected(ID = RandomGroup, Value = 0)]
		public Value.Int RandomGroupA { get; private set; }

		[Key(key = "Easing_IsIndividualTypeEnabled")]
		[Selector(ID = IndividualType)]
		public Value.Boolean IsIndividualTypeEnabled { get; private set; }

		[Key(key = "Easing_IndividualType_A")]
		[Selected(ID = IndividualType, Value = 0)]
		public Value.Enum<EasingType> Type_A
		{
			get;
			private set;
		}

		internal FloatEasingParamater(float value = 0.0f, float max = float.MaxValue, float min = float.MinValue)
        {
			Type = new Value.Enum<EasingType>();

            Start = new Value.FloatWithRandom(value, max, min);
            End = new Value.FloatWithRandom(value, max, min);
            StartSpeed = new Value.Enum<EasingStart>(EasingStart.Start);
            EndSpeed = new Value.Enum<EasingEnd>(EasingEnd.End);

			IsMiddleEnabled = new Value.Boolean(false);
			Middle = new Value.FloatWithRandom(value, max, min);

			IsRandomGroupEnabled = new Value.Boolean(false);

			RandomGroupA = new Value.Int(0);

			IsIndividualTypeEnabled = new Value.Boolean(false);
			Type_A = new Value.Enum<EasingType>(EasingType.Linear);
		}
    }

    public class Vector2DEasingParamater
    {
		[Key(key="Easing_Start")]
        public Value.Vector2DWithRandom Start
        {
            get;
            private set;
        }

		[Key(key="Easing_End")]
		public Value.Vector2DWithRandom End
        {
            get;
            private set;
        }

		[Key(key="Easing_StartSpeed")]
		public Value.Enum<EasingStart> StartSpeed
        {
            get;
            private set;
        }

		[Key(key="Easing_EndSpeed")]
		public Value.Enum<EasingEnd> EndSpeed
        {
            get;
            private set;
        }

        internal Vector2DEasingParamater()
        {
            Start = new Value.Vector2DWithRandom(0, 0);
            End = new Value.Vector2DWithRandom(0, 0);
            StartSpeed = new Value.Enum<EasingStart>(EasingStart.Start);
            EndSpeed = new Value.Enum<EasingEnd>(EasingEnd.End);
        }
    }

	public class Vector3DEasingParamater
	{
		const int EasingTypeGroup = 200;
		const int MiddlePoint = 300;
		const int RandomGroup = 400;
		const int IndividualType = 500;

		[Key(key = "Easing_Start")]
		public Value.Vector3DWithRandom Start
		{
			get;
			private set;
		}

		[Key(key = "Easing_End")]
		public Value.Vector3DWithRandom End
		{
			get;
			private set;
		}

		/// <summary>
		/// 1.6 or later
		/// </summary>
		[Selector(ID = EasingTypeGroup)]
		[Key(key = "Easing_Type")]
		public Value.Enum<EasingType> Type
		{
			get;
			private set;
		}


		[Key(key = "Easing_StartSpeed")]
		[Selected(ID = EasingTypeGroup, Value = (int)EasingType.LeftRightSpeed)]
		public Value.Enum<EasingStart> StartSpeed
		{
			get;
			private set;
		}

		// TODO : selector
		[Key(key = "Easing_EndSpeed")]
		[Selected(ID = EasingTypeGroup, Value = (int)EasingType.LeftRightSpeed)]
		public Value.Enum<EasingEnd> EndSpeed
		{
			get;
			private set;
		}

		[Key(key = "Easing_IsMiddleEnabled")]
		[Selector(ID = MiddlePoint)]
		public Value.Boolean IsMiddleEnabled { get; private set; }


		/// <summary>
		/// 1.6 or later
		/// </summary>
		[Key(key = "Easing_Middle")]
		[Selected(ID = MiddlePoint, Value = 0)]
		public Value.Vector3DWithRandom Middle
		{
			get;
			private set;
		}

		[Key(key = "Easing_IsRandomGroupEnabled")]
		[Selector(ID = RandomGroup)]

		public Value.Boolean IsRandomGroupEnabled { get; private set; }

		/// <summary>
		/// 1.6 or later
		/// </summary>
		[Key(key = "Easing_RandomGroup_X")]
		[Selected(ID = RandomGroup, Value = 0)]
		public Value.Int RandomGroupX { get; private set; }

		/// <summary>
		/// 1.6 or later
		/// </summary>
		[Key(key = "Easing_RandomGroup_Y")]
		[Selected(ID = RandomGroup, Value = 0)]
		public Value.Int RandomGroupY { get; private set; }

		/// <summary>
		/// 1.6 or later
		/// </summary>
		[Key(key = "Easing_RandomGroup_Z")]
		[Selected(ID = RandomGroup, Value = 0)]
		public Value.Int RandomGroupZ { get; private set; }

		[Key(key = "Easing_IsIndividualTypeEnabled")]
		[Selector(ID = IndividualType)]
		public Value.Boolean IsIndividualTypeEnabled { get; private set; }

		[Key(key = "Easing_IndividualType_X")]
		[Selected(ID = IndividualType, Value = 0)]
		public Value.Enum<EasingType> TypeX
		{
			get;
			private set;
		}

		[Key(key = "Easing_IndividualType_Y")]
		[Selected(ID = IndividualType, Value = 0)]
		public Value.Enum<EasingType> TypeY
		{
			get;
			private set;
		}

		[Key(key = "Easing_IndividualType_Z")]
		[Selected(ID = IndividualType, Value = 0)]
		public Value.Enum<EasingType> TypeZ
		{
			get;
			private set;
		}

		internal Vector3DEasingParamater(float defaultX = 0.0f, float defaultY = 0.0f, float defaultZ = 0.0f)
		{
			Type = new Value.Enum<EasingType>();
			Start = new Value.Vector3DWithRandom(defaultX, defaultY, defaultZ);
			Middle = new Value.Vector3DWithRandom(defaultX, defaultY, defaultZ);
			End = new Value.Vector3DWithRandom(defaultX, defaultY, defaultZ);
			StartSpeed = new Value.Enum<EasingStart>(EasingStart.Start);
			EndSpeed = new Value.Enum<EasingEnd>(EasingEnd.End);

			IsMiddleEnabled = new Value.Boolean(false);
			IsRandomGroupEnabled = new Value.Boolean(false);

			RandomGroupX = new Value.Int(0);
			RandomGroupY = new Value.Int(1);
			RandomGroupZ = new Value.Int(2);

			IsIndividualTypeEnabled = new Value.Boolean(false);
			TypeX = new Value.Enum<EasingType>(EasingType.Linear);
			TypeY = new Value.Enum<EasingType>(EasingType.Linear);
			TypeZ = new Value.Enum<EasingType>(EasingType.Linear);
		}
	}

	public class Vector3DFCurveParameter
	{
		[Key(key = "FCurve")]
		[Shown(Shown = true)]
		public Value.FCurveVector3D FCurve
		{
			get;
			private set;
		}

		public Vector3DFCurveParameter()
		{
			FCurve = new Value.FCurveVector3D();
			
			FCurve.X.DefaultValueRangeMax = 10.0f;
			FCurve.X.DefaultValueRangeMin = -10.0f;
			FCurve.Y.DefaultValueRangeMax = 10.0f;
			FCurve.Y.DefaultValueRangeMin = -10.0f;
			FCurve.Z.DefaultValueRangeMax = 10.0f;
			FCurve.Z.DefaultValueRangeMin = -10.0f;
		}
	}

	public enum ProcedualModelType : int
	{
		[Key(key = "ProcedualModelType_Mesh")]
		Mesh,
		[Key(key = "ProcedualModelType_Ribbon")]
		Ribbon,
	}
	public enum ProcedualModelPrimitiveType : int
	{
		[Key(key = "ProcedualModelPrimitiveType_Sphere")]
		Sphere,
		[Key(key = "ProcedualModelPrimitiveType_Cone")]
		Cone,
		[Key(key = "ProcedualModelPrimitiveType_Cylinder")]
		Cylinder,
		[Key(key = "ProcedualModelPrimitiveType_Spline")]
		Spline3,
	}

	public enum ProcedualModelCrossSectionType : int
	{
		[Key(key = "ProcedualModelCrossSectionType_Plane")]
		Plane,
		[Key(key = "ProcedualModelCrossSectionType_Cross")]
		Cross,
		[Key(key = "ProcedualModelCrossSectionType_Point")]
		Point,
	}

	public class ProcedualModelParameter
	{
		const int SelecterType = 100;
		const int SelecterPrimitive = 200;

		[Selector(ID = SelecterType)]
		[Key(key = "PM_Type")]
		public Value.Enum<ProcedualModelType> Type { get; private set; } = new Value.Enum<ProcedualModelType>(ProcedualModelType.Mesh);

		[Selected(ID = SelecterType, Value = (int)ProcedualModelType.Mesh)]
		[Key(key = "PM_AngleBeginEnd")]
		public Value.Vector2D AngleBeginEnd { get; private set; } = new Value.Vector2D(0.0f, 360.0f);

		[Selected(ID = SelecterType, Value = (int)ProcedualModelType.Mesh)]
		[Key(key = "PM_AngleDivision")]
		public Value.Int AngleDivision { get; private set; } = new Value.Int(10, int.MaxValue, 2, 1);

		[Selected(ID = SelecterType, Value = (int)ProcedualModelType.Mesh)]
		[Key(key = "PM_AxisDivision")]
		public Value.Int AxisDivision { get; private set; } = new Value.Int(10, int.MaxValue, 2, 1);

		[Selected(ID = SelecterType, Value = (int)ProcedualModelType.Ribbon)]
		[Key(key = "PM_CrossSection")]
		public Value.Enum<ProcedualModelCrossSectionType> CrossSection { get; private set; } = new Value.Enum<ProcedualModelCrossSectionType>(ProcedualModelCrossSectionType.Plane);

		[Selected(ID = SelecterType, Value = (int)ProcedualModelType.Ribbon)]
		[Key(key = "PM_Rotate")]
		public Value.Float Rotate { get; private set; } = new Value.Float(1.0f);

		[Selected(ID = SelecterType, Value = (int)ProcedualModelType.Ribbon)]
		[Key(key = "PM_Vertices")]
		public Value.Int Vertices { get; private set; } = new Value.Int(10, int.MaxValue, 2, 1);


		[Selected(ID = SelecterType, Value = (int)ProcedualModelType.Ribbon)]
		[Key(key = "PM_ScaleTop")]
		public Value.Vector2D RibbonScales { get; private set; } = new Value.Vector2D(0.2f, 0.2f, x_step: 0.01f, y_step: 0.01f);

		[Selected(ID = SelecterType, Value = (int)ProcedualModelType.Ribbon)]
		[Key(key = "PM_ScaleTop")]
		public Value.Vector2D RibbonAngles { get; private set; } = new Value.Vector2D(0.2f, 0.2f);

		[Selected(ID = SelecterType, Value = (int)ProcedualModelType.Ribbon)]
		[Key(key = "PM_Noises")]
		public Value.Vector2D RibbonNoises { get; private set; } = new Value.Vector2D(0.0f, 0.0f);

		[Selected(ID = SelecterType, Value = (int)ProcedualModelType.Ribbon)]
		[Key(key = "PM_Count")]
		public Value.Int Count { get; private set; } = new Value.Int(2, int.MaxValue, 1);

		[Selector(ID = SelecterPrimitive)]
		[Key(key = "PM_PrimitiveType")]
		public Value.Enum<ProcedualModelPrimitiveType> PrimitiveType { get; private set; } = new Value.Enum<ProcedualModelPrimitiveType>(ProcedualModelPrimitiveType.Sphere);

		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Sphere)]
		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Cone)]
		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Cylinder)]
		[Key(key = "PM_Radius")]
		public Value.Float Radius { get; private set; } = new Value.Float(1.0f);

		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Cylinder)]
		[Key(key = "PM_Radius2")]
		public Value.Float Radius2 { get; private set; } = new Value.Float(1.0f);

		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Cone)]
		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Cylinder)]
		[Key(key = "PM_Depth")]
		public Value.Float Depth { get; private set; } = new Value.Float(1.0f);

		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Sphere)]
		[Key(key = "PM_DepthMin")]
		public Value.Float DepthMin { get; private set; } = new Value.Float(-1.0f);

		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Sphere)]
		[Key(key = "PM_DepthMax")]
		public Value.Float DepthMax { get; private set; } = new Value.Float(1.0f);

		[Key(key = "PM_Point1")]
		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Spline3)]
		public Value.Vector2D Point1 { get; private set; } = new Value.Vector2D(1.0f, 0.0f);

		[Key(key = "PM_Point2")]
		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Spline3)]
		public Value.Vector2D Point2 { get; private set; } = new Value.Vector2D(1.0f, 0.5f);

		[Key(key = "PM_Point3")]
		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Spline3)]
		public Value.Vector2D Point3 { get; private set; } = new Value.Vector2D(1.0f, 1.0f);

		[Key(key = "PM_Point4")]
		[Selected(ID = SelecterPrimitive, Value = (int)ProcedualModelPrimitiveType.Spline3)]
		public Value.Vector2D Point4 { get; private set; } = new Value.Vector2D(1.0f, 2.0f);

		public Value.Vector2D TiltNoiseFrequency { get; private set; } = new Value.Vector2D(1.0f, 1.0f, x_step: 0.01f, y_step: 0.01f);

		public Value.Vector2D TiltNoiseOffset { get; private set; } = new Value.Vector2D(0.0f, 0.0f, x_step: 0.01f, y_step: 0.01f);

		public Value.Vector2D TiltNoisePower { get; private set; } = new Value.Vector2D(0.0f, 0.0f, x_step: 0.01f, y_step: 0.01f);

		public Value.Vector3D WaveNoiseFrequency { get; private set; } = new Value.Vector3D(1.0f, 1.0f, 1.0f, x_step: 0.01f, y_step: 0.01f, z_step:0.01f);
		public Value.Vector3D WaveNoiseOffset { get; private set; } = new Value.Vector3D(0.0f, 0.0f, 0.0f, x_step: 0.01f, y_step: 0.01f, z_step: 0.01f);
		public Value.Vector3D WaveNoisePower { get; private set; } = new Value.Vector3D(0.0f, 0.0f, 0.0f, x_step: 0.01f, y_step: 0.01f, z_step: 0.01f);

		public Value.Vector3D CurlNoiseFrequency { get; private set; } = new Value.Vector3D(1.0f, 1.0f, 1.0f, x_step: 0.01f, y_step: 0.01f, z_step: 0.01f);
		public Value.Vector3D CurlNoiseOffset { get; private set; } = new Value.Vector3D(0.0f, 0.0f, 0.0f, x_step: 0.01f, y_step: 0.01f, z_step: 0.01f);
		public Value.Vector3D CurlNoisePower { get; private set; } = new Value.Vector3D(0.0f, 0.0f, 0.0f, x_step: 0.01f, y_step: 0.01f, z_step: 0.01f);

		public Value.Color ColorLeft { get; private set; } = new Value.Color(255, 255, 255, 255);

		public Value.Color ColorCenter { get; private set; } = new Value.Color(255, 255, 255, 255);

		public Value.Color ColorRight { get; private set; } = new Value.Color(255, 255, 255, 255);

		public Value.Color ColorLeftMiddle { get; private set; } = new Value.Color(255, 255, 255, 255);

		public Value.Color ColorCenterMiddle { get; private set; } = new Value.Color(255, 255, 255, 255);

		public Value.Color ColorRightMiddle { get; private set; } = new Value.Color(255, 255, 255, 255);

		public override bool Equals(object obj)
		{
			var param = obj as ProcedualModelParameter;
			if (param == null)
				return false;

			if (Type.Value != param.Type.Value)
				return false;

			if (Type.Value == ProcedualModelType.Mesh)
			{
				if (AngleBeginEnd.X != param.AngleBeginEnd.X)
					return false;
				if (AngleBeginEnd.Y != param.AngleBeginEnd.Y)
					return false;
				if (AngleDivision.Value != param.AngleDivision.Value)
					return false;
				if (AxisDivision.Value != param.AxisDivision.Value)
					return false;
			}
			else if (Type.Value == ProcedualModelType.Ribbon)
			{
				if (CrossSection.Value != param.CrossSection.Value)
					return false;
				if (Rotate.Value != param.Rotate.Value)
					return false;
				if (Vertices.Value != param.Vertices.Value)
					return false;
				if (!RibbonScales.ValueEquals(param.RibbonScales))
					return false;
				if (!RibbonAngles.ValueEquals(param.RibbonAngles))
					return false;
				if (!RibbonNoises.ValueEquals(param.RibbonNoises))
					return false;
				if (Count.Value != param.Count.Value)
					return false;
			}
			else
			{
				throw new Exception();
			}


			if (PrimitiveType.Value != param.PrimitiveType.Value)
				return false;

			if (PrimitiveType.Value == ProcedualModelPrimitiveType.Sphere)
			{
				if (Radius.Value != param.Radius.Value)
					return false;
				if (DepthMin.Value != param.DepthMin.Value)
					return false;
				if (DepthMax.Value != param.DepthMax.Value)
					return false;
			}
			else if (PrimitiveType.Value == ProcedualModelPrimitiveType.Cone)
			{
				if (Radius.Value != param.Radius.Value)
					return false;
				if (Depth.Value != param.Depth.Value)
					return false;
			}
			else if (PrimitiveType.Value == ProcedualModelPrimitiveType.Cylinder)
			{
				if (Radius.Value != param.Radius.Value)
					return false;
				if (Radius2.Value != param.Radius2.Value)
					return false;
				if (Depth.Value != param.Depth.Value)
					return false;
			}
			else if (PrimitiveType.Value == ProcedualModelPrimitiveType.Spline3)
			{
				if (!Point1.ValueEquals(param.Point1))
					return false;
				if (!Point2.ValueEquals(param.Point2))
					return false;
				if (!Point3.ValueEquals(param.Point3))
					return false;
				if (!Point4.ValueEquals(param.Point4))
					return false;
			}
			else
			{
				throw new Exception();
			}

			if (!TiltNoiseFrequency.ValueEquals(param.TiltNoiseFrequency))
				return false;
			if (!TiltNoiseOffset.ValueEquals(param.TiltNoiseOffset))
				return false;
			if (!TiltNoisePower.ValueEquals(param.TiltNoisePower))
				return false;

			if (!WaveNoiseFrequency.ValueEquals(param.WaveNoiseFrequency))
				return false;
			if (!WaveNoiseOffset.ValueEquals(param.WaveNoiseOffset))
				return false;
			if (!WaveNoisePower.ValueEquals(param.WaveNoisePower))
				return false;

			if (!CurlNoiseFrequency.ValueEquals(param.CurlNoiseFrequency))
				return false;
			if (!CurlNoiseOffset.ValueEquals(param.CurlNoiseOffset))
				return false;
			if (!CurlNoisePower.ValueEquals(param.CurlNoisePower))
				return false;

			if (!ColorLeft.ValueEquals(param.ColorLeft))
				return false;
			if (!ColorCenter.ValueEquals(param.ColorCenter))
				return false;
			if (!ColorRight.ValueEquals(param.ColorRight))
				return false;
			if (!ColorLeftMiddle.ValueEquals(param.ColorLeftMiddle))
				return false;
			if (!ColorCenterMiddle.ValueEquals(param.ColorCenterMiddle))
				return false;
			if (!ColorRightMiddle.ValueEquals(param.ColorRightMiddle))
				return false;
			return true;
		}

		public override int GetHashCode()
		{
			var hash = 0;

			hash = Utils.Misc.CombineHashCodes(new[] { hash, Type.Value.GetHashCode() });

			if (Type.Value == ProcedualModelType.Mesh)
			{
				hash = Utils.Misc.CombineHashCodes(new[] { hash, AngleBeginEnd.X.Value.GetHashCode(), AngleBeginEnd.Y.Value.GetHashCode(), AngleDivision.Value.GetHashCode(), AxisDivision.Value.GetHashCode() });
			}
			else if (Type.Value == ProcedualModelType.Ribbon)
			{
				hash = Utils.Misc.CombineHashCodes(new[] { hash, CrossSection.Value.GetHashCode(), Rotate.Value.GetHashCode(), Vertices.Value.GetHashCode(), RibbonScales.GetValueHashCode(), RibbonAngles.GetValueHashCode(), RibbonNoises.GetValueHashCode(), Count.Value.GetHashCode() });
			}
			else
			{
				throw new Exception();
			}

			hash = Utils.Misc.CombineHashCodes(new[] { hash, PrimitiveType.Value.GetHashCode() });

			if (PrimitiveType.Value == ProcedualModelPrimitiveType.Sphere)
			{
				hash = Utils.Misc.CombineHashCodes(new[] { hash, DepthMin.Value.GetHashCode(), DepthMax.Value.GetHashCode(), Radius.Value.GetHashCode() });
			}
			else if (PrimitiveType.Value == ProcedualModelPrimitiveType.Cone)
			{
				hash = Utils.Misc.CombineHashCodes(new[] { hash, Depth.Value.GetHashCode(), Radius.Value.GetHashCode() });
			}
			else if (PrimitiveType.Value == ProcedualModelPrimitiveType.Cylinder)
			{
				hash = Utils.Misc.CombineHashCodes(new[] { hash, Depth.Value.GetHashCode(), Radius.Value.GetHashCode(), Radius2.Value.GetHashCode() });
			}
			else if (PrimitiveType.Value == ProcedualModelPrimitiveType.Spline3)
			{
				hash = Utils.Misc.CombineHashCodes(new[] { hash, Point1.GetValueHashCode(), Point2.GetValueHashCode(), Point3.GetValueHashCode(), Point4.GetValueHashCode() });
			}
			else
			{
				throw new Exception();
			}


			hash = Utils.Misc.CombineHashCodes(new[] { hash, TiltNoiseFrequency.GetValueHashCode(), TiltNoiseOffset.GetValueHashCode(), TiltNoisePower.GetValueHashCode() });
			hash = Utils.Misc.CombineHashCodes(new[] { hash, WaveNoiseFrequency.GetValueHashCode(), WaveNoiseOffset.GetValueHashCode(), WaveNoisePower.GetValueHashCode() });
			hash = Utils.Misc.CombineHashCodes(new[] { hash, CurlNoiseFrequency.GetValueHashCode(), CurlNoiseOffset.GetValueHashCode(), CurlNoisePower.GetValueHashCode() });

			hash = Utils.Misc.CombineHashCodes(new[] { hash, ColorLeft.GetValueHashCode(), ColorCenter.GetValueHashCode(), ColorRight.GetValueHashCode() });
			hash = Utils.Misc.CombineHashCodes(new[] { hash, ColorLeftMiddle.GetValueHashCode(), ColorCenterMiddle.GetValueHashCode(), ColorRightMiddle.GetValueHashCode() });

			return hash;
		}
	}

	/// <summary>
	/// 入出力に関する属性
	/// </summary>
	[AttributeUsage(
		AttributeTargets.Property | AttributeTargets.Field,
	AllowMultiple = false,
	Inherited = false)]
	public class IOAttribute : Attribute
	{
		public IOAttribute()
		{
			Import = true;
			Export = true;
		}

		public bool Import
		{
			get;
			set;
		}

		public bool Export
		{
			get;
			set;
		}
	}

	/// <summary>
	/// 表示に関する属性
	/// </summary>
	[AttributeUsage(
		AttributeTargets.Property | AttributeTargets.Field,
	AllowMultiple = false,
	Inherited = false)]
	public class ShownAttribute : Attribute
	{
		public ShownAttribute()
		{
			Shown = true;
		}

		public bool Shown
		{
			get;
			set;
		}
	}

	/// <summary>
	/// Undoに関する属性
	/// </summary>
	[AttributeUsage(
		AttributeTargets.Property | AttributeTargets.Field,
	AllowMultiple = false,
	Inherited = false)]
	public class UndoAttribute : Attribute
	{
		public UndoAttribute()
		{
			Undo = true;
		}

		public bool Undo
		{
			get;
			set;
		}
	}

	/// <summary>
	/// A value for a selector
	/// </summary>
	[AttributeUsage(
		AttributeTargets.Property | AttributeTargets.Field,
	AllowMultiple = false,
	Inherited = false)]
	public class SelectorAttribute : Attribute
	{
		public int ID
		{
			get;
			set;
		}

		public SelectorAttribute()
		{
			ID = -1;
		}
	}

	/// <summary>
	/// A values which is shown or hidden with a selector
	/// </summary>
	[AttributeUsage(
		AttributeTargets.Property | AttributeTargets.Field,
	AllowMultiple = true,
	Inherited = false)]
	public class SelectedAttribute : Attribute
	{
		public int ID
		{
			get;
			set;
		}

		public int Value
		{
			get;
			set;
		}

		public SelectedAttribute()
		{
			ID = -1;
			Value = -1;
		}
	}

	/// <summary>
	/// For collection to create a treenode in GUI
	/// </summary>
	[AttributeUsage(
		AttributeTargets.Property | AttributeTargets.Field,
	AllowMultiple = true,
	Inherited = false)]
	public class TreeNodeAttribute : Attribute
	{
		public string key
		{
			get;
			set;
		}

		public string id
		{
			get;
			set;
		}
	}

	/// <summary>
	/// A class to show editable value in parameter list
	/// </summary>
	public class EditableValue
	{
		public object Value;
		public object Title = new MultiLanguageString(string.Empty);
		public object Description = new MultiLanguageString(string.Empty);
		public bool IsUndoEnabled;
		public bool IsShown = true;
		public int SelfSelectorID = -1;
		public string TreeNodeID = null;

		/// <summary>
		/// If this value is larger than 0, target selector id is used to show it.
		/// </summary>
		public int TargetSelectorID = -1;

		/// <summary>
		/// If selector value is included in this, this value is shown.
		/// </summary>
		public int[] RequiredSelectorValues = null;

		public static EditableValue Create(object o, System.Reflection.PropertyInfo info)
		{
			var ret = new EditableValue();
			ret.Value = o;

			var p = info;
			var attributes = p.GetCustomAttributes(false);

			var undo = attributes.Where(_ => _.GetType() == typeof(UndoAttribute)).FirstOrDefault() as UndoAttribute;
			if (undo != null && !undo.Undo)
			{
				ret.IsUndoEnabled = false;
			}
			else
			{
				ret.IsUndoEnabled = true;
			}

			var shown = attributes.Where(_ => _.GetType() == typeof(ShownAttribute)).FirstOrDefault() as ShownAttribute;

			if (shown != null && !shown.Shown)
			{
				ret.IsShown = false;
			}

			var selector_attribute = (from a in attributes where a is Data.SelectorAttribute select a).FirstOrDefault() as Data.SelectorAttribute;
			if (selector_attribute != null)
			{
				ret.SelfSelectorID = selector_attribute.ID;
			}

			// collect selected values
			var selectedAttributes = attributes.OfType<Data.SelectedAttribute>();
			if (selectedAttributes.Count() > 0)
			{
				if(selectedAttributes.Select(_=>_.ID).Distinct().Count() > 1)
				{
					throw new Exception("Same IDs are required.");
				}

				ret.TargetSelectorID = selectedAttributes.First().ID;
				ret.RequiredSelectorValues = selectedAttributes.Select(_ => _.Value).ToArray();
			}

			var key = KeyAttribute.GetKey(attributes);
			var nameKey = key + "_Name";
			if(string.IsNullOrEmpty(key))
			{
				nameKey = info.ReflectedType.Name + "_" + info.Name + "_Name";
			}

			if(MultiLanguageTextProvider.HasKey(nameKey))
			{
				ret.Title = new MultiLanguageString(nameKey);
			}
			else
			{
				ret.Title = NameAttribute.GetName(attributes);
				//if (!string.IsNullOrEmpty(ret.Title.ToString()))
				//{
				//	System.IO.File.AppendAllText("kv.csv", nameKey + ","  + "\"" + ret.Title.ToString() + "\"" + "\r\n");
				//}
			}

			var descKey = key + "_Desc";
			if (string.IsNullOrEmpty(key))
			{
				descKey = info.ReflectedType.Name + "_" + info.Name + "_Desc";
			}

			if (MultiLanguageTextProvider.HasKey(descKey))
			{
				ret.Description = new MultiLanguageString(descKey);
			}
			else
			{
				ret.Description = DescriptionAttribute.GetDescription(attributes);

				//if(!string.IsNullOrEmpty(ret.Description.ToString()))
				//{
				//	System.IO.File.AppendAllText("kv.csv", descKey + "," + "\"" + ret.Description.ToString() + "\"" + "\r\n");
				//}
			}

			var treeNode = attributes.OfType<TreeNodeAttribute>().FirstOrDefault();

			if (treeNode != null)
			{
				ret.TreeNodeID = treeNode.id;

				if (MultiLanguageTextProvider.HasKey(treeNode.key))
				{
					ret.Title = new MultiLanguageString(treeNode.key);
				}

			}

			return ret;
		}
	}

	/// <summary>
	/// An interface to special editable parameters
	/// </summary>
	public interface IEditableValueCollection
	{
		EditableValue[] GetValues();

		event ChangedValueEventHandler OnChanged;
	}

	public interface IResettableValue
	{
		void ResetValue();
	}
}
