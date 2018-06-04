﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_AudioClipWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.AudioClip), typeof(UnityEngine.Object));
		L.RegFunction("LoadAudioData", LoadAudioData);
		L.RegFunction("UnloadAudioData", UnloadAudioData);
		L.RegFunction("GetData", GetData);
		L.RegFunction("SetData", SetData);
		L.RegFunction("Create", Create);
		L.RegFunction("New", _CreateUnityEngine_AudioClip);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("length", get_length, null);
		L.RegFunction("getlength", get_length);
		L.RegVar("samples", get_samples, null);
		L.RegFunction("getsamples", get_samples);
		L.RegVar("channels", get_channels, null);
		L.RegFunction("getchannels", get_channels);
		L.RegVar("frequency", get_frequency, null);
		L.RegFunction("getfrequency", get_frequency);
		L.RegVar("loadType", get_loadType, null);
		L.RegFunction("getloadType", get_loadType);
		L.RegVar("preloadAudioData", get_preloadAudioData, null);
		L.RegFunction("getpreloadAudioData", get_preloadAudioData);
		L.RegVar("loadState", get_loadState, null);
		L.RegFunction("getloadState", get_loadState);
		L.RegVar("loadInBackground", get_loadInBackground, null);
		L.RegFunction("getloadInBackground", get_loadInBackground);
		L.RegFunction("PCMReaderCallback", UnityEngine_AudioClip_PCMReaderCallback);
		L.RegFunction("PCMSetPositionCallback", UnityEngine_AudioClip_PCMSetPositionCallback);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_AudioClip(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.AudioClip obj = new UnityEngine.AudioClip();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.AudioClip.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAudioData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)ToLua.CheckObject(L, 1, typeof(UnityEngine.AudioClip));
			bool o = obj.LoadAudioData();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnloadAudioData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)ToLua.CheckObject(L, 1, typeof(UnityEngine.AudioClip));
			bool o = obj.UnloadAudioData();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)ToLua.CheckObject(L, 1, typeof(UnityEngine.AudioClip));
			float[] arg0 = ToLua.CheckNumberArray<float>(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			bool o = obj.GetData(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)ToLua.CheckObject(L, 1, typeof(UnityEngine.AudioClip));
			float[] arg0 = ToLua.CheckNumberArray<float>(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			bool o = obj.SetData(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Create(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5)
			{
				string arg0 = ToLua.CheckString(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg3 = (int)LuaDLL.luaL_checknumber(L, 4);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
				UnityEngine.AudioClip o = UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushSealed(L, o);
				return 1;
			}
			else if (count == 6)
			{
				string arg0 = ToLua.CheckString(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg3 = (int)LuaDLL.luaL_checknumber(L, 4);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
				UnityEngine.AudioClip.PCMReaderCallback arg5 = (UnityEngine.AudioClip.PCMReaderCallback)ToLua.CheckDelegate<UnityEngine.AudioClip.PCMReaderCallback>(L, 6);
				UnityEngine.AudioClip o = UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4, arg5);
				ToLua.PushSealed(L, o);
				return 1;
			}
			else if (count == 7)
			{
				string arg0 = ToLua.CheckString(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg3 = (int)LuaDLL.luaL_checknumber(L, 4);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
				UnityEngine.AudioClip.PCMReaderCallback arg5 = (UnityEngine.AudioClip.PCMReaderCallback)ToLua.CheckDelegate<UnityEngine.AudioClip.PCMReaderCallback>(L, 6);
				UnityEngine.AudioClip.PCMSetPositionCallback arg6 = (UnityEngine.AudioClip.PCMSetPositionCallback)ToLua.CheckDelegate<UnityEngine.AudioClip.PCMSetPositionCallback>(L, 7);
				UnityEngine.AudioClip o = UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
				ToLua.PushSealed(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AudioClip.Create");
			}
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
	static int get_length(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)o;
			float ret = obj.length;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index length on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_samples(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)o;
			int ret = obj.samples;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index samples on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_channels(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)o;
			int ret = obj.channels;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index channels on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_frequency(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)o;
			int ret = obj.frequency;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index frequency on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loadType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)o;
			UnityEngine.AudioClipLoadType ret = obj.loadType;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index loadType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_preloadAudioData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)o;
			bool ret = obj.preloadAudioData;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index preloadAudioData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loadState(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)o;
			UnityEngine.AudioDataLoadState ret = obj.loadState;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index loadState on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loadInBackground(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AudioClip obj = (UnityEngine.AudioClip)o;
			bool ret = obj.loadInBackground;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index loadInBackground on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_AudioClip_PCMReaderCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.AudioClip.PCMReaderCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.AudioClip.PCMReaderCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_AudioClip_PCMSetPositionCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.AudioClip.PCMSetPositionCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.AudioClip.PCMSetPositionCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

