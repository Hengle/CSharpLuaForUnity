﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_LightWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Light), typeof(UnityEngine.Behaviour));
		L.RegFunction("AddCommandBuffer", AddCommandBuffer);
		L.RegFunction("RemoveCommandBuffer", RemoveCommandBuffer);
		L.RegFunction("RemoveCommandBuffers", RemoveCommandBuffers);
		L.RegFunction("RemoveAllCommandBuffers", RemoveAllCommandBuffers);
		L.RegFunction("GetCommandBuffers", GetCommandBuffers);
		L.RegFunction("GetLights", GetLights);
		L.RegFunction("New", _CreateUnityEngine_Light);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("type", get_type, set_type);
		L.RegFunction("gettype", get_type);
		L.RegFunction("settype", set_type);
		L.RegVar("color", get_color, set_color);
		L.RegFunction("getcolor", get_color);
		L.RegFunction("setcolor", set_color);
		L.RegVar("intensity", get_intensity, set_intensity);
		L.RegFunction("getintensity", get_intensity);
		L.RegFunction("setintensity", set_intensity);
		L.RegVar("bounceIntensity", get_bounceIntensity, set_bounceIntensity);
		L.RegFunction("getbounceIntensity", get_bounceIntensity);
		L.RegFunction("setbounceIntensity", set_bounceIntensity);
		L.RegVar("shadows", get_shadows, set_shadows);
		L.RegFunction("getshadows", get_shadows);
		L.RegFunction("setshadows", set_shadows);
		L.RegVar("shadowStrength", get_shadowStrength, set_shadowStrength);
		L.RegFunction("getshadowStrength", get_shadowStrength);
		L.RegFunction("setshadowStrength", set_shadowStrength);
		L.RegVar("shadowResolution", get_shadowResolution, set_shadowResolution);
		L.RegFunction("getshadowResolution", get_shadowResolution);
		L.RegFunction("setshadowResolution", set_shadowResolution);
		L.RegVar("shadowCustomResolution", get_shadowCustomResolution, set_shadowCustomResolution);
		L.RegFunction("getshadowCustomResolution", get_shadowCustomResolution);
		L.RegFunction("setshadowCustomResolution", set_shadowCustomResolution);
		L.RegVar("shadowBias", get_shadowBias, set_shadowBias);
		L.RegFunction("getshadowBias", get_shadowBias);
		L.RegFunction("setshadowBias", set_shadowBias);
		L.RegVar("shadowNormalBias", get_shadowNormalBias, set_shadowNormalBias);
		L.RegFunction("getshadowNormalBias", get_shadowNormalBias);
		L.RegFunction("setshadowNormalBias", set_shadowNormalBias);
		L.RegVar("shadowNearPlane", get_shadowNearPlane, set_shadowNearPlane);
		L.RegFunction("getshadowNearPlane", get_shadowNearPlane);
		L.RegFunction("setshadowNearPlane", set_shadowNearPlane);
		L.RegVar("range", get_range, set_range);
		L.RegFunction("getrange", get_range);
		L.RegFunction("setrange", set_range);
		L.RegVar("spotAngle", get_spotAngle, set_spotAngle);
		L.RegFunction("getspotAngle", get_spotAngle);
		L.RegFunction("setspotAngle", set_spotAngle);
		L.RegVar("cookieSize", get_cookieSize, set_cookieSize);
		L.RegFunction("getcookieSize", get_cookieSize);
		L.RegFunction("setcookieSize", set_cookieSize);
		L.RegVar("cookie", get_cookie, set_cookie);
		L.RegFunction("getcookie", get_cookie);
		L.RegFunction("setcookie", set_cookie);
		L.RegVar("flare", get_flare, set_flare);
		L.RegFunction("getflare", get_flare);
		L.RegFunction("setflare", set_flare);
		L.RegVar("renderMode", get_renderMode, set_renderMode);
		L.RegFunction("getrenderMode", get_renderMode);
		L.RegFunction("setrenderMode", set_renderMode);
		L.RegVar("bakedIndex", get_bakedIndex, set_bakedIndex);
		L.RegFunction("getbakedIndex", get_bakedIndex);
		L.RegFunction("setbakedIndex", set_bakedIndex);
		L.RegVar("isBaked", get_isBaked, null);
		L.RegFunction("getisBaked", get_isBaked);
		L.RegVar("cullingMask", get_cullingMask, set_cullingMask);
		L.RegFunction("getcullingMask", get_cullingMask);
		L.RegFunction("setcullingMask", set_cullingMask);
		L.RegVar("commandBufferCount", get_commandBufferCount, null);
		L.RegFunction("getcommandBufferCount", get_commandBufferCount);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Light(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Light obj = new UnityEngine.Light();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Light.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddCommandBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Light obj = (UnityEngine.Light)ToLua.CheckObject(L, 1, typeof(UnityEngine.Light));
			UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)ToLua.CheckObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
			obj.AddCommandBuffer(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveCommandBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Light obj = (UnityEngine.Light)ToLua.CheckObject(L, 1, typeof(UnityEngine.Light));
			UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)ToLua.CheckObject(L, 3, typeof(UnityEngine.Rendering.CommandBuffer));
			obj.RemoveCommandBuffer(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveCommandBuffers(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Light obj = (UnityEngine.Light)ToLua.CheckObject(L, 1, typeof(UnityEngine.Light));
			UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaDLL.luaL_checknumber(L, 2);
			obj.RemoveCommandBuffers(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAllCommandBuffers(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)ToLua.CheckObject(L, 1, typeof(UnityEngine.Light));
			obj.RemoveAllCommandBuffers();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCommandBuffers(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Light obj = (UnityEngine.Light)ToLua.CheckObject(L, 1, typeof(UnityEngine.Light));
			UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Rendering.CommandBuffer[] o = obj.GetCommandBuffers(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLights(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.LightType arg0 = (UnityEngine.LightType)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Light[] o = UnityEngine.Light.GetLights(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.LightType ret = obj.type;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index type on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_color(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.Color ret = obj.color;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index color on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_intensity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float ret = obj.intensity;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index intensity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bounceIntensity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float ret = obj.bounceIntensity;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bounceIntensity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadows(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.LightShadows ret = obj.shadows;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadows on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowStrength(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float ret = obj.shadowStrength;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowStrength on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowResolution(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.Rendering.LightShadowResolution ret = obj.shadowResolution;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowResolution on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCustomResolution(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			int ret = obj.shadowCustomResolution;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowCustomResolution on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float ret = obj.shadowBias;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowNormalBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float ret = obj.shadowNormalBias;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowNormalBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowNearPlane(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float ret = obj.shadowNearPlane;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowNearPlane on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_range(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float ret = obj.range;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index range on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spotAngle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float ret = obj.spotAngle;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index spotAngle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cookieSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float ret = obj.cookieSize;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cookieSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cookie(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.Texture ret = obj.cookie;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cookie on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flare(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.Flare ret = obj.flare;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index flare on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.LightRenderMode ret = obj.renderMode;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bakedIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			int ret = obj.bakedIndex;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bakedIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isBaked(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			bool ret = obj.isBaked;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isBaked on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cullingMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			int ret = obj.cullingMask;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cullingMask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_commandBufferCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			int ret = obj.commandBufferCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index commandBufferCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.LightType arg0 = (UnityEngine.LightType)LuaDLL.luaL_checknumber(L, 2);
			obj.type = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index type on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_color(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.color = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index color on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_intensity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.intensity = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index intensity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bounceIntensity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.bounceIntensity = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bounceIntensity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadows(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.LightShadows arg0 = (UnityEngine.LightShadows)LuaDLL.luaL_checknumber(L, 2);
			obj.shadows = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadows on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowStrength(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.shadowStrength = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowStrength on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowResolution(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.Rendering.LightShadowResolution arg0 = (UnityEngine.Rendering.LightShadowResolution)LuaDLL.luaL_checknumber(L, 2);
			obj.shadowResolution = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowResolution on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCustomResolution(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.shadowCustomResolution = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowCustomResolution on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.shadowBias = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowNormalBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.shadowNormalBias = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowNormalBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowNearPlane(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.shadowNearPlane = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shadowNearPlane on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_range(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.range = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index range on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_spotAngle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.spotAngle = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index spotAngle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cookieSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.cookieSize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cookieSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cookie(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.Texture arg0 = (UnityEngine.Texture)ToLua.CheckObject<UnityEngine.Texture>(L, 2);
			obj.cookie = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cookie on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_flare(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.Flare arg0 = (UnityEngine.Flare)ToLua.CheckObject(L, 2, typeof(UnityEngine.Flare));
			obj.flare = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index flare on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			UnityEngine.LightRenderMode arg0 = (UnityEngine.LightRenderMode)LuaDLL.luaL_checknumber(L, 2);
			obj.renderMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bakedIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.bakedIndex = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bakedIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cullingMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Light obj = (UnityEngine.Light)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.cullingMask = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cullingMask on a nil value");
		}
	}
}

