﻿
//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
#include "Effekseer.Setting.h"

#include "Effekseer.RectF.h"

#include "Effekseer.CurveLoader.h"
#include "Effekseer.EffectLoader.h"
#include "Effekseer.MaterialLoader.h"
#include "Effekseer.SoundLoader.h"
#include "Effekseer.TextureLoader.h"
#include "Model/ModelLoader.h"

#include "Renderer/Effekseer.ModelRenderer.h"
#include "Renderer/Effekseer.RibbonRenderer.h"
#include "Renderer/Effekseer.RingRenderer.h"
#include "Renderer/Effekseer.SpriteRenderer.h"
#include "Renderer/Effekseer.TrackRenderer.h"

#include "Effekseer.Effect.h"
#include "IO/Effekseer.EfkEfcFactory.h"
#include "Model/ProcedualModelGenerator.h"

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
namespace Effekseer
{

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
Setting::Setting()
	: m_coordinateSystem(CoordinateSystem::RH)
	, m_effectLoader(NULL)
	, m_textureLoader(NULL)
	, m_soundLoader(NULL)
	, m_modelLoader(NULL)
	, m_curveLoader(NULL)
{
	auto effectFactory = new EffectFactory();
	effectFactories.push_back(effectFactory);

	// this function is for 1.6
	auto efkefcFactory = new EfkEfcFactory();
	effectFactories.push_back(efkefcFactory);

	procedualMeshGenerator_ = new ProcedualModelGenerator();
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
Setting::~Setting()
{
	ClearEffectFactory();

	ES_SAFE_DELETE(m_effectLoader);
	ES_SAFE_DELETE(m_textureLoader);
	ES_SAFE_DELETE(m_soundLoader);
	ES_SAFE_DELETE(m_modelLoader);
	ES_SAFE_DELETE(m_materialLoader);
	ES_SAFE_DELETE(m_curveLoader);
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
Setting* Setting::Create()
{
	return new Setting();
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
CoordinateSystem Setting::GetCoordinateSystem() const
{
	return m_coordinateSystem;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void Setting::SetCoordinateSystem(CoordinateSystem coordinateSystem)
{
	m_coordinateSystem = coordinateSystem;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
EffectLoader* Setting::GetEffectLoader()
{
	return m_effectLoader;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void Setting::SetEffectLoader(EffectLoader* loader)
{
	ES_SAFE_DELETE(m_effectLoader);
	m_effectLoader = loader;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
TextureLoader* Setting::GetTextureLoader()
{
	return m_textureLoader;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void Setting::SetTextureLoader(TextureLoader* loader)
{
	ES_SAFE_DELETE(m_textureLoader);
	m_textureLoader = loader;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
ModelLoader* Setting::GetModelLoader()
{
	return m_modelLoader;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void Setting::SetModelLoader(ModelLoader* loader)
{
	ES_SAFE_DELETE(m_modelLoader);
	m_modelLoader = loader;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
SoundLoader* Setting::GetSoundLoader()
{
	return m_soundLoader;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void Setting::SetSoundLoader(SoundLoader* loader)
{
	ES_SAFE_DELETE(m_soundLoader);
	m_soundLoader = loader;
}

MaterialLoader* Setting::GetMaterialLoader()
{
	return m_materialLoader;
}

void Setting::SetMaterialLoader(MaterialLoader* loader)
{
	ES_SAFE_DELETE(m_materialLoader);
	m_materialLoader = loader;
}

CurveLoader* Setting::GetCurveLoader()
{
	return m_curveLoader;
}

void Setting::SetCurveLoader(CurveLoader* loader)
{
	ES_SAFE_DELETE(m_curveLoader);
	m_curveLoader = loader;
}

ProcedualModelGenerator* Setting::GetProcedualMeshGenerator() const
{
	return procedualMeshGenerator_;
}

void Setting::SetProcedualMeshGenerator(ProcedualModelGenerator* generator)
{
	ES_SAFE_ADDREF(generator);
	ES_SAFE_RELEASE(procedualMeshGenerator_);
	procedualMeshGenerator_ = generator;
}

void Setting::AddEffectFactory(EffectFactory* effectFactory)
{

	if (effectFactory == nullptr)
		return;
	ES_SAFE_ADDREF(effectFactory);
	effectFactories.push_back(effectFactory);
}

void Setting::ClearEffectFactory()
{
	for (auto& e : effectFactories)
	{
		ES_SAFE_RELEASE(e);
	}
	effectFactories.clear();
}

EffectFactory* Setting::GetEffectFactory(int32_t ind) const
{
	return effectFactories[ind];
}

int32_t Setting::GetEffectFactoryCount() const
{
	return static_cast<int32_t>(effectFactories.size());
}

} // namespace Effekseer
  //----------------------------------------------------------------------------------
  //
  //----------------------------------------------------------------------------------