#ifndef __EFFEKSEER_PROCEDUAL_MODEL_PARAMETER_H__
#define __EFFEKSEER_PROCEDUAL_MODEL_PARAMETER_H__

#include "../Utils/Effekseer.BinaryReader.h"
#include <stdint.h>
#include <stdio.h>

namespace Effekseer
{

static bool operator==(const std::array<float, 2>& lhs, const std::array<float, 2>& rhs)
{
	for (size_t i = 0; i < lhs.size(); i++)
	{
		if (lhs[i] != rhs[i])
		{
			return false;
		}
	}

	return true;
}

static bool operator<(const std::array<float, 2>& lhs, const std::array<float, 2>& rhs)
{
	for (size_t i = 0; i < lhs.size(); i++)
	{
		if (lhs[i] != rhs[i])
		{
			return lhs[i] < rhs[i];
		}
	}

	return false;
}

static bool operator==(const std::array<float, 3>& lhs, const std::array<float, 3>& rhs)
{
	for (size_t i = 0; i < lhs.size(); i++)
	{
		if (lhs[i] != rhs[i])
		{
			return false;
		}
	}

	return true;
}

static bool operator<(const std::array<float, 3>& lhs, const std::array<float, 3>& rhs)
{
	for (size_t i = 0; i < lhs.size(); i++)
	{
		if (lhs[i] != rhs[i])
		{
			return lhs[i] < rhs[i];
		}
	}

	return false;
}

enum class ProcedualModelType : int32_t
{
	Mesh,
	Ribbon,
};

enum class ProcedualModelPrimitiveType : int32_t
{
	Sphere,
	Cone,
	Cylinder,
};

enum class ProcedualModelCrossSectionType : int32_t
{
	Plane,
	Cross,
	Point,
};

struct ProcedualModelParameter
{
	ProcedualModelType Type;
	ProcedualModelPrimitiveType PrimitiveType;

	union {
		struct
		{
			float AngleBegin;
			float AngleEnd;
			int AngleDivision;
			int DepthDivision;
		} Mesh;

		struct
		{
			ProcedualModelCrossSectionType CrossSection;
			float Rotate;
			int Vertices;
			float SizeBottom;
			float SizeTop;
			std::array<float, 2> RibbonNoises;
			int Count;
		} Ribbon;
	};

	union {
		struct
		{
			float Radius;
			float DepthMin;
			float DepthMax;
		} Sphere;

		struct
		{
			float Radius;
			float Depth;
		} Cone;

		struct
		{
			float Radius1;
			float Radius2;
			float Depth;
		} Cylinder;
	};

	std::array<float, 2> TiltNoiseFrequency = {};
	std::array<float, 2> TiltNoiseOffset = {};
	std::array<float, 2> TiltNoisePower = {};

	std::array<float, 3> WaveNoiseFrequency = {};
	std::array<float, 3> WaveNoiseOffset = {};
	std::array<float, 3> WaveNoisePower = {};

	std::array<float, 3> CurlNoiseFrequency = {};
	std::array<float, 3> CurlNoiseOffset = {};
	std::array<float, 3> CurlNoisePower = {};

	bool operator<(const ProcedualModelParameter& rhs) const
	{
		if (Type != rhs.Type)
		{
			return static_cast<int32_t>(Type) < static_cast<int32_t>(rhs.Type);
		}

		if (Type == ProcedualModelType::Mesh)
		{
			if (Mesh.AngleBegin != rhs.Mesh.AngleBegin)
				return Mesh.AngleBegin < rhs.Mesh.AngleBegin;

			if (Mesh.AngleEnd != rhs.Mesh.AngleEnd)
				return Mesh.AngleEnd < rhs.Mesh.AngleEnd;

			if (Mesh.AngleDivision != rhs.Mesh.AngleDivision)
				return Mesh.AngleDivision < rhs.Mesh.AngleDivision;

			if (Mesh.DepthDivision != rhs.Mesh.DepthDivision)
				return Mesh.DepthDivision < rhs.Mesh.DepthDivision;
		}
		else if (Type == ProcedualModelType::Ribbon)
		{
			if (Ribbon.CrossSection != rhs.Ribbon.CrossSection)
				return Ribbon.CrossSection < rhs.Ribbon.CrossSection;

			if (Ribbon.Rotate != rhs.Ribbon.Rotate)
				return Ribbon.Rotate < rhs.Ribbon.Rotate;

			if (Ribbon.Vertices != rhs.Ribbon.Vertices)
				return Ribbon.Vertices < rhs.Ribbon.Vertices;

			if (Ribbon.SizeBottom != rhs.Ribbon.SizeBottom)
				return Ribbon.SizeBottom < rhs.Ribbon.SizeBottom;

			if (Ribbon.SizeTop != rhs.Ribbon.SizeTop)
				return Ribbon.SizeTop < rhs.Ribbon.SizeTop;

			if (Ribbon.RibbonNoises[0] != rhs.Ribbon.RibbonNoises[0])
				return Ribbon.RibbonNoises[0] < rhs.Ribbon.RibbonNoises[0];

			if (Ribbon.RibbonNoises[1] != rhs.Ribbon.RibbonNoises[1])
				return Ribbon.RibbonNoises[1] < rhs.Ribbon.RibbonNoises[1];

			if (Ribbon.Count != rhs.Ribbon.Count)
				return Ribbon.Count < rhs.Ribbon.Count;
		}
		else
		{
			assert(0);
		}

		if (PrimitiveType != rhs.PrimitiveType)
		{
			return static_cast<int32_t>(PrimitiveType) < static_cast<int32_t>(rhs.PrimitiveType);
		}

		if (PrimitiveType == ProcedualModelPrimitiveType::Sphere)
		{
			if (Sphere.Radius != rhs.Sphere.Radius)
				return Sphere.Radius < rhs.Sphere.Radius;

			if (Sphere.DepthMin != rhs.Sphere.DepthMin)
				return Sphere.DepthMax < rhs.Sphere.DepthMax;
		}
		else if (PrimitiveType == ProcedualModelPrimitiveType::Cone)
		{
			if (Cone.Radius != rhs.Cone.Radius)
				return Cone.Radius < rhs.Cone.Radius;

			if (Cone.Depth != rhs.Cone.Depth)
				return Cone.Depth < rhs.Cone.Depth;
		}
		else if (PrimitiveType == ProcedualModelPrimitiveType::Cylinder)
		{
			if (Cylinder.Radius1 != rhs.Cylinder.Radius1)
				return Cylinder.Radius1 < rhs.Cylinder.Radius1;

			if (Cylinder.Radius2 != rhs.Cylinder.Radius2)
				return Cylinder.Radius2 < rhs.Cylinder.Radius2;

			if (Cylinder.Depth != rhs.Cylinder.Depth)
				return Cylinder.Depth < rhs.Cylinder.Depth;
		}
		else
		{
			assert(0);
		}

		if (TiltNoiseFrequency != rhs.TiltNoiseFrequency)
			return TiltNoiseFrequency < rhs.TiltNoiseFrequency;

		if (TiltNoiseOffset != rhs.TiltNoiseOffset)
			return TiltNoiseOffset < rhs.TiltNoiseOffset;

		if (TiltNoisePower != rhs.TiltNoisePower)
			return TiltNoisePower < rhs.TiltNoisePower;

		if (WaveNoiseFrequency != rhs.WaveNoiseFrequency)
			return WaveNoiseFrequency < rhs.WaveNoiseFrequency;

		if (WaveNoiseOffset != rhs.WaveNoiseOffset)
			return WaveNoiseOffset < rhs.WaveNoiseOffset;

		if (WaveNoisePower != rhs.WaveNoisePower)
			return WaveNoisePower < rhs.WaveNoisePower;

		if (CurlNoiseFrequency != rhs.CurlNoiseFrequency)
			return CurlNoiseFrequency < rhs.CurlNoiseFrequency;

		if (CurlNoiseOffset != rhs.CurlNoiseOffset)
			return CurlNoiseOffset < rhs.CurlNoiseOffset;

		if (CurlNoisePower != rhs.CurlNoisePower)
			return CurlNoisePower < rhs.CurlNoisePower;

		return false;
	}

	template <bool T>
	bool Load(BinaryReader<T>& reader)
	{
		reader.Read(Type);

		if (Type == ProcedualModelType::Mesh)
		{
			reader.Read(Mesh.AngleBegin);
			reader.Read(Mesh.AngleEnd);
			reader.Read(Mesh.AngleDivision);
			reader.Read(Mesh.DepthDivision);
		}
		else if (Type == ProcedualModelType::Ribbon)
		{
			reader.Read(Ribbon.CrossSection);
			reader.Read(Ribbon.Rotate);
			reader.Read(Ribbon.Vertices);
			reader.Read(Ribbon.SizeBottom);
			reader.Read(Ribbon.SizeTop);
			reader.Read(Ribbon.RibbonNoises[0]);
			reader.Read(Ribbon.RibbonNoises[1]);
			reader.Read(Ribbon.Count);
		}
		else
		{
			assert(0);
		}

		reader.Read(PrimitiveType);

		if (PrimitiveType == ProcedualModelPrimitiveType::Sphere)
		{
			reader.Read(Sphere.Radius);
			reader.Read(Sphere.DepthMin);
			reader.Read(Sphere.DepthMax);
		}
		else if (PrimitiveType == ProcedualModelPrimitiveType::Cone)
		{
			reader.Read(Cone.Radius);
			reader.Read(Cone.Depth);
		}
		else if (PrimitiveType == ProcedualModelPrimitiveType::Cylinder)
		{
			reader.Read(Cylinder.Radius1);
			reader.Read(Cylinder.Radius2);
			reader.Read(Cylinder.Depth);
		}

		reader.Read(TiltNoiseFrequency);
		reader.Read(TiltNoiseOffset);
		reader.Read(TiltNoisePower);

		reader.Read(WaveNoiseFrequency);
		reader.Read(WaveNoiseOffset);
		reader.Read(WaveNoisePower);

		reader.Read(CurlNoiseFrequency);
		reader.Read(CurlNoiseOffset);
		reader.Read(CurlNoisePower);

		return true;
	}
};

} // namespace Effekseer

#endif