// Xbim.Geometry.Portable.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#define EXTERN_DLL_EXPORT extern "C" __declspec(dllexport)

EXTERN_DLL_EXPORT int getEngineVersion() {
	return 1;
}
