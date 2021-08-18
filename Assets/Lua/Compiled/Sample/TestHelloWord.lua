-- Generated by CSharp.lua Compiler
local System = System
local UnityEngine = UnityEngine
local Sample
System.import(function (out)
  Sample = out.Sample
end)
System.namespace("Sample", function (namespace)
  namespace.class("TestHelloWord", function (namespace)
    local Awake, Start, Update
    Awake = function (this)
      UnityEngine.Debug.Log("TestHelloWord")
      this:getgameObject():AddComponent(Sample.TestCoroutine)
      local c = this:GetComponent(UnityEngine.MonoBehaviour)
      UnityEngine.MonoBehaviour.print(c:getname())

      local obj1 = UnityEngine.Object.FindObjectOfType(UnityEngine.MonoBehaviour)
      UnityEngine.Object.Destroy(obj1)

      local i = TestUtils.Load("Assets/CSharpLua/Examples/01_HelloWorld/TestLoader.prefab")
      local obj = UnityEngine.Object.Instantiate(i)
      obj:gettransform():setparent(this:gettransform())

      Sample.TestProtobuf.Run()
    end
    Start = function (this)
      UnityEngine.MonoBehaviour.print("TestHelloWord.Start")
    end
    Update = function (this)
      UnityEngine.MonoBehaviour.print("TestHelloWord.Update")
    end
    return {
      base = function (out)
        return {
          out.UnityEngine.MonoBehaviour
        }
      end,
      Awake = Awake,
      Start = Start,
      Update = Update
    }
  end)
end)
