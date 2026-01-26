#include "pch-cpp.hpp"





struct VirtualActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct VirtualActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1>
struct VirtualActionInvoker1Invoker;
template <typename T1>
struct VirtualActionInvoker1Invoker<T1*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1* p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		void* params[1] = { p1 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[0]);
	}
};
template <typename T1, typename T2, typename T3>
struct VirtualActionInvoker3Invoker;
template <typename T1, typename T2, typename T3>
struct VirtualActionInvoker3Invoker<T1*, T2*, T3*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1* p1, T2* p2, T3* p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		void* params[3] = { p1, p2, p3 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[2]);
	}
};
template <typename T1, typename T2, typename T3, typename T4>
struct VirtualActionInvoker4Invoker;
template <typename T1, typename T2, typename T3, typename T4>
struct VirtualActionInvoker4Invoker<T1*, T2*, T3*, T4*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		void* params[4] = { p1, p2, p3, p4 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[3]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct VirtualActionInvoker5Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct VirtualActionInvoker5Invoker<T1*, T2*, T3*, T4*, T5*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		void* params[5] = { p1, p2, p3, p4, p5 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[4]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct VirtualActionInvoker6Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct VirtualActionInvoker6Invoker<T1*, T2*, T3*, T4*, T5*, T6*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		void* params[6] = { p1, p2, p3, p4, p5, p6 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[5]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7>
struct VirtualActionInvoker7Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7>
struct VirtualActionInvoker7Invoker<T1*, T2*, T3*, T4*, T5*, T6*, T7*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6, T7* p7)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		void* params[7] = { p1, p2, p3, p4, p5, p6, p7 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[6]);
	}
};
template <typename T1, typename T2, typename T3>
struct GenericVirtualActionInvoker3Invoker;
template <typename T1, typename T2, typename T3>
struct GenericVirtualActionInvoker3Invoker<T1*, T2*, T3*>
{
	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1* p1, T2* p2, T3* p3)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		void* params[3] = { p1, p2, p3 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[2]);
	}
};
template <typename T1, typename T2, typename T3, typename T4>
struct GenericVirtualActionInvoker4Invoker;
template <typename T1, typename T2, typename T3, typename T4>
struct GenericVirtualActionInvoker4Invoker<T1*, T2*, T3*, T4*>
{
	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		void* params[4] = { p1, p2, p3, p4 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[3]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct GenericVirtualActionInvoker5Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct GenericVirtualActionInvoker5Invoker<T1*, T2*, T3*, T4*, T5*>
{
	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		void* params[5] = { p1, p2, p3, p4, p5 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[4]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct GenericVirtualActionInvoker6Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct GenericVirtualActionInvoker6Invoker<T1*, T2*, T3*, T4*, T5*, T6*>
{
	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		void* params[6] = { p1, p2, p3, p4, p5, p6 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[5]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7>
struct GenericVirtualActionInvoker7Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7>
struct GenericVirtualActionInvoker7Invoker<T1*, T2*, T3*, T4*, T5*, T6*, T7*>
{
	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6, T7* p7)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		void* params[7] = { p1, p2, p3, p4, p5, p6, p7 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[6]);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1Invoker;
template <typename T1>
struct InterfaceActionInvoker1Invoker<T1*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1* p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		void* params[1] = { p1 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[0]);
	}
};
template <typename T1, typename T2, typename T3>
struct InterfaceActionInvoker3Invoker;
template <typename T1, typename T2, typename T3>
struct InterfaceActionInvoker3Invoker<T1*, T2*, T3*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1* p1, T2* p2, T3* p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		void* params[3] = { p1, p2, p3 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[2]);
	}
};
template <typename T1, typename T2, typename T3, typename T4>
struct InterfaceActionInvoker4Invoker;
template <typename T1, typename T2, typename T3, typename T4>
struct InterfaceActionInvoker4Invoker<T1*, T2*, T3*, T4*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		void* params[4] = { p1, p2, p3, p4 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[3]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct InterfaceActionInvoker5Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct InterfaceActionInvoker5Invoker<T1*, T2*, T3*, T4*, T5*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		void* params[5] = { p1, p2, p3, p4, p5 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[4]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct InterfaceActionInvoker6Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct InterfaceActionInvoker6Invoker<T1*, T2*, T3*, T4*, T5*, T6*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		void* params[6] = { p1, p2, p3, p4, p5, p6 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[5]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7>
struct InterfaceActionInvoker7Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7>
struct InterfaceActionInvoker7Invoker<T1*, T2*, T3*, T4*, T5*, T6*, T7*>
{
	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6, T7* p7)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		void* params[7] = { p1, p2, p3, p4, p5, p6, p7 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[6]);
	}
};
template <typename R, typename T1>
struct InterfaceFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2, typename T3>
struct GenericInterfaceActionInvoker3Invoker;
template <typename T1, typename T2, typename T3>
struct GenericInterfaceActionInvoker3Invoker<T1*, T2*, T3*>
{
	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1* p1, T2* p2, T3* p3)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		void* params[3] = { p1, p2, p3 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[2]);
	}
};
template <typename T1, typename T2, typename T3, typename T4>
struct GenericInterfaceActionInvoker4Invoker;
template <typename T1, typename T2, typename T3, typename T4>
struct GenericInterfaceActionInvoker4Invoker<T1*, T2*, T3*, T4*>
{
	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		void* params[4] = { p1, p2, p3, p4 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[3]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct GenericInterfaceActionInvoker5Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct GenericInterfaceActionInvoker5Invoker<T1*, T2*, T3*, T4*, T5*>
{
	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		void* params[5] = { p1, p2, p3, p4, p5 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[4]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct GenericInterfaceActionInvoker6Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct GenericInterfaceActionInvoker6Invoker<T1*, T2*, T3*, T4*, T5*, T6*>
{
	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		void* params[6] = { p1, p2, p3, p4, p5, p6 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[5]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7>
struct GenericInterfaceActionInvoker7Invoker;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7>
struct GenericInterfaceActionInvoker7Invoker<T1*, T2*, T3*, T4*, T5*, T6*, T7*>
{
	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6, T7* p7)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		void* params[7] = { p1, p2, p3, p4, p5, p6, p7 };
		invokeData.method->invoker_method(il2cpp_codegen_get_method_pointer(invokeData.method), invokeData.method, obj, params, params[6]);
	}
};
template <typename T1>
struct InvokerActionInvoker1;
template <typename T1>
struct InvokerActionInvoker1<T1*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1)
	{
		void* params[1] = { p1 };
		method->invoker_method(methodPtr, method, obj, params, params[0]);
	}
};
template <typename T1, typename T2>
struct InvokerActionInvoker2;
template <typename T1, typename T2>
struct InvokerActionInvoker2<T1*, T2*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2)
	{
		void* params[2] = { p1, p2 };
		method->invoker_method(methodPtr, method, obj, params, params[1]);
	}
};
template <typename T1, typename T2, typename T3>
struct InvokerActionInvoker3;
template <typename T1, typename T2, typename T3>
struct InvokerActionInvoker3<T1*, T2*, T3*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2, T3* p3)
	{
		void* params[3] = { p1, p2, p3 };
		method->invoker_method(methodPtr, method, obj, params, params[2]);
	}
};
template <typename T1, typename T2, typename T3, typename T4>
struct InvokerActionInvoker4;
template <typename T1, typename T2, typename T3, typename T4>
struct InvokerActionInvoker4<T1*, T2*, T3*, T4*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2, T3* p3, T4* p4)
	{
		void* params[4] = { p1, p2, p3, p4 };
		method->invoker_method(methodPtr, method, obj, params, params[3]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct InvokerActionInvoker5;
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct InvokerActionInvoker5<T1*, T2*, T3*, T4*, T5*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5)
	{
		void* params[5] = { p1, p2, p3, p4, p5 };
		method->invoker_method(methodPtr, method, obj, params, params[4]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct InvokerActionInvoker6;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct InvokerActionInvoker6<T1*, T2*, T3*, T4*, T5*, T6*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6)
	{
		void* params[6] = { p1, p2, p3, p4, p5, p6 };
		method->invoker_method(methodPtr, method, obj, params, params[5]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7>
struct InvokerActionInvoker7;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7>
struct InvokerActionInvoker7<T1*, T2*, T3*, T4*, T5*, T6*, T7*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6, T7* p7)
	{
		void* params[7] = { p1, p2, p3, p4, p5, p6, p7 };
		method->invoker_method(methodPtr, method, obj, params, params[6]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7, typename T8>
struct InvokerActionInvoker8;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7, typename T8>
struct InvokerActionInvoker8<T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6, T7* p7, T8* p8)
	{
		void* params[8] = { p1, p2, p3, p4, p5, p6, p7, p8 };
		method->invoker_method(methodPtr, method, obj, params, params[7]);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7, typename T8, typename T9>
struct InvokerActionInvoker9;
template <typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7, typename T8, typename T9>
struct InvokerActionInvoker9<T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2, T3* p3, T4* p4, T5* p5, T6* p6, T7* p7, T8* p8, T9* p9)
	{
		void* params[9] = { p1, p2, p3, p4, p5, p6, p7, p8, p9 };
		method->invoker_method(methodPtr, method, obj, params, params[8]);
	}
};
template <typename R, typename T1>
struct InvokerFuncInvoker1;
template <typename R, typename T1>
struct InvokerFuncInvoker1<R, T1*>
{
	static inline R Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1)
	{
		R ret;
		void* params[1] = { p1 };
		method->invoker_method(methodPtr, method, obj, params, &ret);
		return ret;
	}
};
template <typename R, typename T1, typename T2>
struct InvokerFuncInvoker2;
template <typename R, typename T1, typename T2>
struct InvokerFuncInvoker2<R, T1*, T2>
{
	static inline R Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2 p2)
	{
		R ret;
		void* params[2] = { p1, &p2 };
		method->invoker_method(methodPtr, method, obj, params, &ret);
		return ret;
	}
};
template <typename R, typename T1, typename T2>
struct InvokerFuncInvoker2<R, T1*, T2*>
{
	static inline R Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2)
	{
		R ret;
		void* params[2] = { p1, p2 };
		method->invoker_method(methodPtr, method, obj, params, &ret);
		return ret;
	}
};

struct Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87;
struct AsyncReactiveProperty_1_t55DCE046DB85F4B8B8BFAD7AE879EE536D5F9733;
struct ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583;
struct ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD;
struct Func_2_tE1F0D41563EE092E5E5540B061449FDE88F1DC00;
struct Func_2_t19E50C11C3E1F20B5A8FDB85D7DD353B6DFF868B;
struct Func_3_tF03057D8F2223EA4C7E5EF1FABBE4CE367A43326;
struct Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F;
struct Func_3_tDADD7F9B266FDB16BDFFC46D6D5A79E7EA04406E;
struct Func_3_tECED1961B53AB164A131061296ABA1276B4FBBB9;
struct Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4;
struct Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821;
struct IList_1_t8AC59FFD0F90EC2DAD4C3FA39B2A5851F9D2987A;
struct IObservable_1_t3B5CA6CF57A9734CD1D166FB2074FE7FB725EDDC;
struct IObservable_1_tA29A83F0C2D67B7465AEA27D123F8F8B6514E475;
struct IObserver_1_tBC6CE0DC9E0C4FC95DA956CA90305E2B00BD5785;
struct IObserver_1_t86359CF84DEFEE15EB1DB5AFA5F2E8A27FF22D3B;
struct IObserver_1_t094BE2515872266E98A772AEA02B413105F16A8B;
struct ITriggerHandler_1_t53BCC826B29B27388A8A63C9E80F17313AB22E2C;
struct IUniTaskAsyncEnumerator_1_t256C7409E6B13FF3224A57D2DD1A4D52A2C40092;
struct OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627;
struct Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41;
struct ReadOnlyAsyncReactiveProperty_1_tB7349A20B00D8047434C5CDE4CB7EC263380B1E9;
struct SparselyPopulatedArrayFragment_1_tB32DA8C2B7461E80CE4C271B76C103629BDFA035;
struct WhereObservable_1_t3ED825243E1FF00921A3F094DE46F8E1636EF293;
struct WhereObservable_1_tAEF5B968677E7DD944B72065B689C7D6D0F557A0;
struct Where__t5104F30F0CF1DB24C11737FBAF6AE85C06330FB8;
struct Where__tC1CFF1B49CFDEDB8F32C86A7A354330BD141B79C;
struct WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4;
struct WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885;
struct WithoutCurrentEnumerable_t61691720F7363FB52D0166233D6F1CDEC9A12368;
struct WithoutCurrentEnumerable_tA165573F50CE7FD8626E075AE98BC04DE9B29888;
struct WriteDelegate_t6A0EB21668C92D873ACB875924DE54518D8B7234;
struct WriteDelegate_t737D0DA8D96562AD76BB67D9C5A5199EDB0171E1;
struct WriteDelegate_t907C2DAF3A619B832C6D9441AF1C4CDA7914AF1D;
struct WriteDelegate_tE9F20B5E1A664D239EFDD91143B963A216AAB1C7;
struct WriteDelegate_t023838BBDB83C818E9FDC98ABFA9A9396823E789;
struct WriteDelegate_t98EF2EAAD5827503FF2F0213C32A4961968D75A0;
struct WriteDelegate_t055D02BADD3A5DFA009116D80BC93C235313CAE8;
struct WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7;
struct XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A;
struct XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D;
struct XHashtable_1_t4C208624C5DAFD8858B7794DF15C5747BE4B3072;
struct XHashtable_1_t781B821CC6AC13BED190536310819EB7FD1463D0;
struct Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380;
struct Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746;
struct Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC;
struct Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228;
struct Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700;
struct Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49;
struct Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3;
struct ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D;
struct ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962;
struct ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965;
struct ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9;
struct ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC;
struct ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A;
struct ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527;
struct ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957;
struct ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D;
struct ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2;
struct ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1;
struct ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D;
struct ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB;
struct ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183;
struct ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69;
struct ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6;
struct ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795;
struct ZipLatestObservable_1_t2A28BD239FCAB16DD9001B4A9F9D9F151D9CD77C;
struct ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091;
struct ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04;
struct ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07;
struct ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2;
struct ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576;
struct ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA;
struct ZipLatestObserver_t4BE85AB314360398FC0402187EBCBE96BFF04C75;
struct ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5;
struct ZipObservable_1_tCF96E17B3CE750A3553A6CE43DA7472BC77222B2;
struct ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21;
struct ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3;
struct ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A;
struct ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961;
struct ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5;
struct ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4;
struct ZipObserver_tEA117F108743D9CF50FE3CBC8B616BB5C58F6AA2;
struct ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802;
struct EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635;
struct EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4;
struct IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035;
struct Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3;
struct BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4;
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273;
struct IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
struct Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD;
struct __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC;
struct LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263;
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07;
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
struct CancellationCallbackInfo_tC8BE558ED1E173434DD1919D574C9FAFE501E22D;
struct CancellationTokenSource_tAAE1E0033BCFC233801F8CB4CED5C852B350CB7B;
struct Delegate_t;
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
struct Exception_t;
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
struct ICancelable_tB1DEE5D3AD44B45D562C30F81A032B6CDF33DCF4;
struct ICollection_t37E7B9DC5B4EF41D190D607F92835BF1171C0E8E;
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
struct IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5;
struct IZipLatestObservable_t1DCB33AEA6D887F2440884F643B4910BB9011EE7;
struct IZipObservable_t1908F5805FDF1CC2A33A432ECDEF367981470A11;
struct Light_t1E68479B7782AF2050FAA02A5DC612FD034F18F3;
struct MethodInfo_t;
struct OverflowException_t6F6AD8CACE20C37F701C05B373A215C4802FAB0C;
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
struct SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE;
struct String_t;
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;

IL2CPP_EXTERN_C RuntimeClass* Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IZipLatestObservable_t1DCB33AEA6D887F2440884F643B4910BB9011EE7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IZipObservable_t1908F5805FDF1CC2A33A432ECDEF367981470A11_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* OverflowException_t6F6AD8CACE20C37F701C05B373A215C4802FAB0C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimeObject_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Sorting_tBB4ACAADCAA21EA710DD3998A0614ABDEF8FD8A6_il2cpp_TypeInfo_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635;
struct EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4;
struct IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035;
struct Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3;
struct BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4;
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273;
struct IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD;
struct __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC;
struct LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
struct LeftObserver_tBD9CC4BC709982E0C2956F9F65443C863A5055BE  : public RuntimeObject
{
	WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4* ___parent;
};
struct LeftObserver_tB7E464B198322A284E0266355C4DACB5A3A3B66E  : public RuntimeObject
{
	ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527* ___parent;
};
struct LeftZipObserver_tF654ECFF4ABF554CCB22A1BD44613E0BB6A39ACD  : public RuntimeObject
{
	Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746* ___parent;
};
struct List_1_tDBA89B0E21BAC58CFBD3C1F76E4668E3B562761A  : public RuntimeObject
{
	__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ____items;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct OperatorObservableBase_1_tBFE60A390AADA301289FC0A01C56C68B84E92F41  : public RuntimeObject
{
	bool ___isRequiredSubscribeOnCurrentThread;
};
struct OperatorObservableBase_1_tC97A0ACB65300244FF346581F87AC2E4492B5386  : public RuntimeObject
{
	bool ___isRequiredSubscribeOnCurrentThread;
};
struct OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE  : public RuntimeObject
{
	bool ___isRequiredSubscribeOnCurrentThread;
};
struct OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E  : public RuntimeObject
{
	RuntimeObject* ___observer;
	RuntimeObject* ___cancel;
};
struct OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627  : public RuntimeObject
{
	RuntimeObject* ___observer;
	RuntimeObject* ___cancel;
};
struct OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37  : public RuntimeObject
{
	RuntimeObject* ___observer;
	RuntimeObject* ___cancel;
};
struct Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41  : public RuntimeObject
{
	__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ____array;
	int32_t ____head;
	int32_t ____tail;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct RightObserver_tD89649C363EBB9D55FD41D18A2603BE0282C6FBE  : public RuntimeObject
{
	WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4* ___parent;
	RuntimeObject* ___selfSubscription;
};
struct RightObserver_tCD0571F80F305840348F458D5771051BDE215447  : public RuntimeObject
{
	ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527* ___parent;
};
struct RightZipObserver_t9BB70D85E6615F51DC252B76D25F1158B0963E3F  : public RuntimeObject
{
	Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746* ___parent;
};
struct WithoutCurrentEnumerable_t61691720F7363FB52D0166233D6F1CDEC9A12368  : public RuntimeObject
{
	AsyncReactiveProperty_1_t55DCE046DB85F4B8B8BFAD7AE879EE536D5F9733* ___parent;
};
struct WithoutCurrentEnumerable_tA165573F50CE7FD8626E075AE98BC04DE9B29888  : public RuntimeObject
{
	ReadOnlyAsyncReactiveProperty_1_tB7349A20B00D8047434C5CDE4CB7EC263380B1E9* ___parent;
};
struct XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A  : public RuntimeObject
{
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets;
	EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* ____entries;
	int32_t ____numEntries;
	ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* ____extractKey;
};
struct XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D  : public RuntimeObject
{
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets;
	EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* ____entries;
	int32_t ____numEntries;
	ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD* ____extractKey;
};
struct XHashtable_1_t4C208624C5DAFD8858B7794DF15C5747BE4B3072  : public RuntimeObject
{
	XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* ____state;
};
struct XHashtable_1_t781B821CC6AC13BED190536310819EB7FD1463D0  : public RuntimeObject
{
	XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* ____state;
};
struct ZipLatestObserver_t4BE85AB314360398FC0402187EBCBE96BFF04C75  : public RuntimeObject
{
	ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* ___parent;
	int32_t ___index;
};
struct ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5 : public RuntimeObject {};
struct ZipObserver_tEA117F108743D9CF50FE3CBC8B616BB5C58F6AA2  : public RuntimeObject
{
	Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* ___parent;
	int32_t ___index;
};
struct ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802  : public RuntimeObject
{
	RuntimeObject* ___gate;
	RuntimeObject* ___parent;
	int32_t ___index;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___queue;
};
struct SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE  : public RuntimeObject
{
	RuntimeObject* ___gate;
	RuntimeObject* ___current;
	bool ___disposed;
};
struct String_t  : public RuntimeObject
{
	int32_t ____stringLength;
	Il2CppChar ____firstChar;
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};
struct Entry_t6E72C722C46949F140550D563C1F41E304752583 
{
	RuntimeObject* ___Value;
	int32_t ___HashCode;
	int32_t ___Next;
};
typedef Il2CppFullySharedGenericStruct Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E;
struct NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857  : public OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37
{
	int32_t ___length;
	BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* ___isStarted;
	BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* ___isCompleted;
};
struct NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158  : public OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37
{
	ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* ___queues;
	BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* ___isDone;
	int32_t ___length;
};
struct SparselyPopulatedArrayAddInfo_1_t3C73DC53EB2CF8545348E3275C09690FFA1E5359 
{
	SparselyPopulatedArrayFragment_1_tB32DA8C2B7461E80CE4C271B76C103629BDFA035* ____source;
	int32_t ____index;
};
struct TriggerEvent_1_t4D603DB487DB30F0FBD2EE01A6AF71CA4F4476E0 
{
	RuntimeObject* ___head;
	RuntimeObject* ___iteratingHead;
	RuntimeObject* ___iteratingNode;
};
struct UniTaskCompletionSourceCore_1_t9AED094DEF9EF1E050603D158F4FFA169DE3E9D2 
{
	bool ___result;
	RuntimeObject* ___error;
	int16_t ___version;
	bool ___hasUnhandledError;
	int32_t ___completedCount;
	Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___continuation;
	RuntimeObject* ___continuationState;
};
struct WhereObservable_1_t3ED825243E1FF00921A3F094DE46F8E1636EF293  : public OperatorObservableBase_1_tC97A0ACB65300244FF346581F87AC2E4492B5386
{
	RuntimeObject* ___source;
	Func_2_tE1F0D41563EE092E5E5540B061449FDE88F1DC00* ___predicate;
	Func_3_tF03057D8F2223EA4C7E5EF1FABBE4CE367A43326* ___predicateWithIndex;
};
struct WhereObservable_1_tAEF5B968677E7DD944B72065B689C7D6D0F557A0  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source;
	Func_2_t19E50C11C3E1F20B5A8FDB85D7DD353B6DFF868B* ___predicate;
	Func_3_tDADD7F9B266FDB16BDFFC46D6D5A79E7EA04406E* ___predicateWithIndex;
};
struct Where__t5104F30F0CF1DB24C11737FBAF6AE85C06330FB8  : public OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627
{
	WhereObservable_1_t3ED825243E1FF00921A3F094DE46F8E1636EF293* ___parent;
	int32_t ___index;
};
struct Where__tC1CFF1B49CFDEDB8F32C86A7A354330BD141B79C  : public OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37
{
	WhereObservable_1_tAEF5B968677E7DD944B72065B689C7D6D0F557A0* ___parent;
	int32_t ___index;
};
struct WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4 : public OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37 {};
struct WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___left;
	RuntimeObject* ___right;
	Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* ___selector;
};
struct WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44 
{
	Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___m_Data;
	int32_t ___m_Start;
	int32_t ___m_Length;
};
struct WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809 
{
	__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___m_Data;
	int32_t ___m_Start;
	int32_t ___m_Length;
};
struct WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87 
{
	LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___m_Data;
	int32_t ___m_Start;
	int32_t ___m_Length;
};
struct Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380  : public OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E
{
	ZipObservable_1_tCF96E17B3CE750A3553A6CE43DA7472BC77222B2* ___parent;
	RuntimeObject* ___gate;
	Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3* ___queues;
	BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* ___isDone;
	int32_t ___length;
};
struct Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746  : public OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37
{
	ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* ___parent;
	RuntimeObject* ___gate;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___leftQ;
	bool ___leftCompleted;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___rightQ;
	bool ___rightCompleted;
};
struct ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A  : public OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E
{
	ZipLatestObservable_1_t2A28BD239FCAB16DD9001B4A9F9D9F151D9CD77C* ___parent;
	RuntimeObject* ___gate;
	int32_t ___length;
	__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___values;
	BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* ___isStarted;
	BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* ___isCompleted;
};
struct ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527 : public OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37 {};
struct ZipLatestObservable_1_t2A28BD239FCAB16DD9001B4A9F9D9F151D9CD77C  : public OperatorObservableBase_1_tBFE60A390AADA301289FC0A01C56C68B84E92F41
{
	IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035* ___sources;
};
struct ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___left;
	RuntimeObject* ___right;
	Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* ___selector;
};
struct ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source1;
	RuntimeObject* ___source2;
	RuntimeObject* ___source3;
	ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* ___resultSelector;
};
struct ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source1;
	RuntimeObject* ___source2;
	RuntimeObject* ___source3;
	RuntimeObject* ___source4;
	ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* ___resultSelector;
};
struct ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source1;
	RuntimeObject* ___source2;
	RuntimeObject* ___source3;
	RuntimeObject* ___source4;
	RuntimeObject* ___source5;
	ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* ___resultSelector;
};
struct ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source1;
	RuntimeObject* ___source2;
	RuntimeObject* ___source3;
	RuntimeObject* ___source4;
	RuntimeObject* ___source5;
	RuntimeObject* ___source6;
	ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* ___resultSelector;
};
struct ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source1;
	RuntimeObject* ___source2;
	RuntimeObject* ___source3;
	RuntimeObject* ___source4;
	RuntimeObject* ___source5;
	RuntimeObject* ___source6;
	RuntimeObject* ___source7;
	ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* ___resultSelector;
};
struct ZipObservable_1_tCF96E17B3CE750A3553A6CE43DA7472BC77222B2  : public OperatorObservableBase_1_tBFE60A390AADA301289FC0A01C56C68B84E92F41
{
	IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035* ___sources;
};
struct ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___left;
	RuntimeObject* ___right;
	Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* ___selector;
};
struct ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source1;
	RuntimeObject* ___source2;
	RuntimeObject* ___source3;
	ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* ___resultSelector;
};
struct ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source1;
	RuntimeObject* ___source2;
	RuntimeObject* ___source3;
	RuntimeObject* ___source4;
	ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* ___resultSelector;
};
struct ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source1;
	RuntimeObject* ___source2;
	RuntimeObject* ___source3;
	RuntimeObject* ___source4;
	RuntimeObject* ___source5;
	ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* ___resultSelector;
};
struct ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source1;
	RuntimeObject* ___source2;
	RuntimeObject* ___source3;
	RuntimeObject* ___source4;
	RuntimeObject* ___source5;
	RuntimeObject* ___source6;
	ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* ___resultSelector;
};
struct ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4  : public OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE
{
	RuntimeObject* ___source1;
	RuntimeObject* ___source2;
	RuntimeObject* ___source3;
	RuntimeObject* ___source4;
	RuntimeObject* ___source5;
	RuntimeObject* ___source6;
	RuntimeObject* ___source7;
	ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* ___resultSelector;
};
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	bool ___m_value;
};
struct CancellationToken_t51142D9C6D7C02D314DA34A6A7988C528992FFED 
{
	CancellationTokenSource_tAAE1E0033BCFC233801F8CB4CED5C852B350CB7B* ____source;
};
struct CancellationToken_t51142D9C6D7C02D314DA34A6A7988C528992FFED_marshaled_pinvoke
{
	CancellationTokenSource_tAAE1E0033BCFC233801F8CB4CED5C852B350CB7B* ____source;
};
struct CancellationToken_t51142D9C6D7C02D314DA34A6A7988C528992FFED_marshaled_com
{
	CancellationTokenSource_tAAE1E0033BCFC233801F8CB4CED5C852B350CB7B* ____source;
};
struct Char_t521A6F19B456D956AF452D926C32709DC03D6B17 
{
	Il2CppChar ___m_value;
};
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	int32_t ___m_value;
};
struct IntPtr_t 
{
	void* ___m_value;
};
struct Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D 
{
	float ___m_XMin;
	float ___m_YMin;
	float ___m_Width;
	float ___m_Height;
};
struct RectInt_t1744D10E1063135DA9D574F95205B98DAC600CB8 
{
	int32_t ___m_XMin;
	int32_t ___m_YMin;
	int32_t ___m_Width;
	int32_t ___m_Height;
};
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	float ___m_value;
};
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 
{
	float ___x;
	float ___y;
};
struct Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A 
{
	int32_t ___m_X;
	int32_t ___m_Y;
};
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	float ___x;
	float ___y;
	float ___z;
};
struct Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376 
{
	int32_t ___m_X;
	int32_t ___m_Y;
	int32_t ___m_Z;
};
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 
{
	float ___x;
	float ___y;
	float ___z;
	float ___w;
};
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};
struct LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 
{
	uint16_t ___visibleLightIndex;
	uint16_t ___lightBufferIndex;
	Light_t1E68479B7782AF2050FAA02A5DC612FD034F18F3* ___light;
};
struct LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2_marshaled_pinvoke
{
	uint16_t ___visibleLightIndex;
	uint16_t ___lightBufferIndex;
	Light_t1E68479B7782AF2050FAA02A5DC612FD034F18F3* ___light;
};
struct LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2_marshaled_com
{
	uint16_t ___visibleLightIndex;
	uint16_t ___lightBufferIndex;
	Light_t1E68479B7782AF2050FAA02A5DC612FD034F18F3* ___light;
};
struct AsyncReactiveProperty_1_t55DCE046DB85F4B8B8BFAD7AE879EE536D5F9733 : public RuntimeObject {};
struct ReadOnlyAsyncReactiveProperty_1_tB7349A20B00D8047434C5CDE4CB7EC263380B1E9 : public RuntimeObject {};
struct Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC  : public NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158
{
	ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* ___parent;
	RuntimeObject* ___gate;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q1;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q2;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q3;
};
struct Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228  : public NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158
{
	ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* ___parent;
	RuntimeObject* ___gate;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q1;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q2;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q3;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q4;
};
struct Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700  : public NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158
{
	ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* ___parent;
	RuntimeObject* ___gate;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q1;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q2;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q3;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q4;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q5;
};
struct Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49  : public NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158
{
	ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* ___parent;
	RuntimeObject* ___gate;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q1;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q2;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q3;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q4;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q5;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q6;
};
struct Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3  : public NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158
{
	ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* ___parent;
	RuntimeObject* ___gate;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q1;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q2;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q3;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q4;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q5;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q6;
	Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___q7;
};
struct ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957  : public NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857
{
	ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* ___parent;
	RuntimeObject* ___gate;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c1;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c2;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c3;
};
struct ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D  : public NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857
{
	ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* ___parent;
	RuntimeObject* ___gate;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c1;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c2;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c3;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c4;
};
struct ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2  : public NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857
{
	ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* ___parent;
	RuntimeObject* ___gate;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c1;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c2;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c3;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c4;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c5;
};
struct ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1  : public NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857
{
	ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* ___parent;
	RuntimeObject* ___gate;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c1;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c2;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c3;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c4;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c5;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c6;
};
struct ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D  : public NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857
{
	ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* ___parent;
	RuntimeObject* ___gate;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c1;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c2;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c3;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c4;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c5;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c6;
	ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* ___c7;
};
struct CancellationTokenRegistration_tC925A8BC86C629A2A3DA73765FA964A95FC83389 
{
	CancellationCallbackInfo_tC8BE558ED1E173434DD1919D574C9FAFE501E22D* ___m_callbackInfo;
	SparselyPopulatedArrayAddInfo_1_t3C73DC53EB2CF8545348E3275C09690FFA1E5359 ___m_registrationInfo;
};
struct CancellationTokenRegistration_tC925A8BC86C629A2A3DA73765FA964A95FC83389_marshaled_pinvoke
{
	CancellationCallbackInfo_tC8BE558ED1E173434DD1919D574C9FAFE501E22D* ___m_callbackInfo;
	SparselyPopulatedArrayAddInfo_1_t3C73DC53EB2CF8545348E3275C09690FFA1E5359 ___m_registrationInfo;
};
struct CancellationTokenRegistration_tC925A8BC86C629A2A3DA73765FA964A95FC83389_marshaled_com
{
	CancellationCallbackInfo_tC8BE558ED1E173434DD1919D574C9FAFE501E22D* ___m_callbackInfo;
	SparselyPopulatedArrayAddInfo_1_t3C73DC53EB2CF8545348E3275C09690FFA1E5359 ___m_registrationInfo;
};
struct Delegate_t  : public RuntimeObject
{
	intptr_t ___method_ptr;
	intptr_t ___invoke_impl;
	RuntimeObject* ___m_target;
	intptr_t ___method;
	intptr_t ___delegate_trampoline;
	intptr_t ___extra_arg;
	intptr_t ___method_code;
	intptr_t ___interp_method;
	intptr_t ___interp_invoke_impl;
	MethodInfo_t* ___method_info;
	MethodInfo_t* ___original_method_info;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data;
	bool ___method_is_virtual;
};
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr;
	intptr_t ___invoke_impl;
	Il2CppIUnknown* ___m_target;
	intptr_t ___method;
	intptr_t ___delegate_trampoline;
	intptr_t ___extra_arg;
	intptr_t ___method_code;
	intptr_t ___interp_method;
	intptr_t ___interp_invoke_impl;
	MethodInfo_t* ___method_info;
	MethodInfo_t* ___original_method_info;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data;
	int32_t ___method_is_virtual;
};
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr;
	intptr_t ___invoke_impl;
	Il2CppIUnknown* ___m_target;
	intptr_t ___method;
	intptr_t ___delegate_trampoline;
	intptr_t ___extra_arg;
	intptr_t ___method_code;
	intptr_t ___interp_method;
	intptr_t ___interp_invoke_impl;
	MethodInfo_t* ___method_info;
	MethodInfo_t* ___original_method_info;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data;
	int32_t ___method_is_virtual;
};
struct Exception_t  : public RuntimeObject
{
	String_t* ____className;
	String_t* ____message;
	RuntimeObject* ____data;
	Exception_t* ____innerException;
	String_t* ____helpURL;
	RuntimeObject* ____stackTrace;
	String_t* ____stackTraceString;
	String_t* ____remoteStackTraceString;
	int32_t ____remoteStackIndex;
	RuntimeObject* ____dynamicMethods;
	int32_t ____HResult;
	String_t* ____source;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces;
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips;
	int32_t ___caught_in_unmanaged;
};
struct Exception_t_marshaled_pinvoke
{
	char* ____className;
	char* ____message;
	RuntimeObject* ____data;
	Exception_t_marshaled_pinvoke* ____innerException;
	char* ____helpURL;
	Il2CppIUnknown* ____stackTrace;
	char* ____stackTraceString;
	char* ____remoteStackTraceString;
	int32_t ____remoteStackIndex;
	Il2CppIUnknown* ____dynamicMethods;
	int32_t ____HResult;
	char* ____source;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces;
	Il2CppSafeArray* ___native_trace_ips;
	int32_t ___caught_in_unmanaged;
};
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className;
	Il2CppChar* ____message;
	RuntimeObject* ____data;
	Exception_t_marshaled_com* ____innerException;
	Il2CppChar* ____helpURL;
	Il2CppIUnknown* ____stackTrace;
	Il2CppChar* ____stackTraceString;
	Il2CppChar* ____remoteStackTraceString;
	int32_t ____remoteStackIndex;
	Il2CppIUnknown* ____dynamicMethods;
	int32_t ____HResult;
	Il2CppChar* ____source;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces;
	Il2CppSafeArray* ___native_trace_ips;
	int32_t ___caught_in_unmanaged;
};
struct MoveNextSource_tEE80ED59B6626D9814CD4A1DDD53D32F0A9495B5  : public RuntimeObject
{
	UniTaskCompletionSourceCore_1_t9AED094DEF9EF1E050603D158F4FFA169DE3E9D2 ___completionSource;
};
struct Enumerator_t52AB038CB588CDE841350C02AA5D28DAAA6DBA60 : public MoveNextSource_tEE80ED59B6626D9814CD4A1DDD53D32F0A9495B5 {};
struct Enumerator_t2264BA8CF3D7072C596172D20E9E9AB2BF7CF0BE : public MoveNextSource_tEE80ED59B6626D9814CD4A1DDD53D32F0A9495B5 {};
struct MulticastDelegate_t  : public Delegate_t
{
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates;
};
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates;
};
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates;
};
struct SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295  : public Exception_t
{
};
struct ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583  : public MulticastDelegate_t
{
};
struct ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD  : public MulticastDelegate_t
{
};
struct Func_3_tF03057D8F2223EA4C7E5EF1FABBE4CE367A43326  : public MulticastDelegate_t
{
};
struct Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F  : public MulticastDelegate_t
{
};
struct Func_3_tDADD7F9B266FDB16BDFFC46D6D5A79E7EA04406E  : public MulticastDelegate_t
{
};
struct Func_3_tECED1961B53AB164A131061296ABA1276B4FBBB9  : public MulticastDelegate_t
{
};
struct Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4  : public MulticastDelegate_t
{
};
struct Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821  : public MulticastDelegate_t
{
};
struct WriteDelegate_t6A0EB21668C92D873ACB875924DE54518D8B7234  : public MulticastDelegate_t
{
};
struct WriteDelegate_t737D0DA8D96562AD76BB67D9C5A5199EDB0171E1  : public MulticastDelegate_t
{
};
struct WriteDelegate_t907C2DAF3A619B832C6D9441AF1C4CDA7914AF1D  : public MulticastDelegate_t
{
};
struct WriteDelegate_tE9F20B5E1A664D239EFDD91143B963A216AAB1C7  : public MulticastDelegate_t
{
};
struct WriteDelegate_t023838BBDB83C818E9FDC98ABFA9A9396823E789  : public MulticastDelegate_t
{
};
struct WriteDelegate_t98EF2EAAD5827503FF2F0213C32A4961968D75A0  : public MulticastDelegate_t
{
};
struct WriteDelegate_t055D02BADD3A5DFA009116D80BC93C235313CAE8  : public MulticastDelegate_t
{
};
struct WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7  : public MulticastDelegate_t
{
};
struct ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D  : public MulticastDelegate_t
{
};
struct ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962  : public MulticastDelegate_t
{
};
struct ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965  : public MulticastDelegate_t
{
};
struct ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9  : public MulticastDelegate_t
{
};
struct ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC  : public MulticastDelegate_t
{
};
struct ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB  : public MulticastDelegate_t
{
};
struct ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183  : public MulticastDelegate_t
{
};
struct ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69  : public MulticastDelegate_t
{
};
struct ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6  : public MulticastDelegate_t
{
};
struct ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795  : public MulticastDelegate_t
{
};
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07  : public MulticastDelegate_t
{
};
struct ArithmeticException_t07E77822D0007642BC8959A671E70D1F33C84FEA  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C  : public MulticastDelegate_t
{
};
struct OverflowException_t6F6AD8CACE20C37F701C05B373A215C4802FAB0C  : public ArithmeticException_t07E77822D0007642BC8959A671E70D1F33C84FEA
{
};
struct List_1_tDBA89B0E21BAC58CFBD3C1F76E4668E3B562761A_StaticFields
{
	__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___s_emptyArray;
};
struct String_t_StaticFields
{
	String_t* ___Empty;
};
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	String_t* ___TrueString;
	String_t* ___FalseString;
};
struct CancellationToken_t51142D9C6D7C02D314DA34A6A7988C528992FFED_StaticFields
{
	Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___s_actionToActionObjShunt;
};
struct Char_t521A6F19B456D956AF452D926C32709DC03D6B17_StaticFields
{
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___s_categoryForLatin1;
};
struct IntPtr_t_StaticFields
{
	intptr_t ___Zero;
};
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields
{
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___zeroVector;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___oneVector;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___upVector;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___downVector;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___leftVector;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___rightVector;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___positiveInfinityVector;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___negativeInfinityVector;
};
struct Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A_StaticFields
{
	Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A ___s_Zero;
	Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A ___s_One;
	Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A ___s_Up;
	Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A ___s_Down;
	Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A ___s_Left;
	Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A ___s_Right;
};
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector;
};
struct Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376_StaticFields
{
	Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376 ___s_Zero;
	Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376 ___s_One;
	Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376 ___s_Up;
	Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376 ___s_Down;
	Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376 ___s_Left;
	Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376 ___s_Right;
	Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376 ___s_Forward;
	Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376 ___s_Back;
};
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_StaticFields
{
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___zeroVector;
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___oneVector;
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___positiveInfinityVector;
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___negativeInfinityVector;
};
struct LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2_StaticFields
{
	Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821* ___s_CompareByCookieSize;
	Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821* ___s_CompareByBufferIndex;
};
struct AsyncReactiveProperty_1_t55DCE046DB85F4B8B8BFAD7AE879EE536D5F9733_StaticFields
{
	bool ___isValueType;
};
struct ReadOnlyAsyncReactiveProperty_1_tB7349A20B00D8047434C5CDE4CB7EC263380B1E9_StaticFields
{
	bool ___isValueType;
};
struct Exception_t_StaticFields
{
	RuntimeObject* ___s_EDILock;
};
struct Enumerator_t52AB038CB588CDE841350C02AA5D28DAAA6DBA60_StaticFields
{
	Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___cancellationCallback;
};
struct Enumerator_t2264BA8CF3D7072C596172D20E9E9AB2BF7CF0BE_StaticFields
{
	Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___cancellationCallback;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
struct Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD  : public RuntimeArray
{
	ALIGN_FIELD (8) Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 m_Items[1];

	inline Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 value)
	{
		m_Items[index] = value;
	}
};
struct __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC  : public RuntimeArray
{
	ALIGN_FIELD (8) uint8_t m_Items[1];

	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + il2cpp_array_calc_byte_offset(this, index);
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + il2cpp_array_calc_byte_offset(this, index);
	}
};
struct LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263  : public RuntimeArray
{
	ALIGN_FIELD (8) LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 m_Items[1];

	inline LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___light), (void*)NULL);
	}
	inline LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___light), (void*)NULL);
	}
};
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C  : public RuntimeArray
{
	ALIGN_FIELD (8) int32_t m_Items[1];

	inline int32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
struct EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635  : public RuntimeArray
{
	ALIGN_FIELD (8) Entry_t6E72C722C46949F140550D563C1F41E304752583 m_Items[1];

	inline Entry_t6E72C722C46949F140550D563C1F41E304752583 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Entry_t6E72C722C46949F140550D563C1F41E304752583* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Entry_t6E72C722C46949F140550D563C1F41E304752583 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___Value), (void*)NULL);
	}
	inline Entry_t6E72C722C46949F140550D563C1F41E304752583 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Entry_t6E72C722C46949F140550D563C1F41E304752583* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Entry_t6E72C722C46949F140550D563C1F41E304752583 value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___Value), (void*)NULL);
	}
};
struct EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4  : public RuntimeArray
{
	ALIGN_FIELD (8) uint8_t m_Items[1];

	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + il2cpp_array_calc_byte_offset(this, index);
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + il2cpp_array_calc_byte_offset(this, index);
	}
};
struct IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
struct IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
struct Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3  : public RuntimeArray
{
	ALIGN_FIELD (8) Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* m_Items[1];

	inline Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
struct BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4  : public RuntimeArray
{
	ALIGN_FIELD (8) bool m_Items[1];

	inline bool GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline bool* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, bool value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline bool GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline bool* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, bool value)
	{
		m_Items[index] = value;
	}
};
struct ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OperatorObserverBase_2__ctor_m6D849DC0DD5EE34A22139215AEB9594684813863_gshared (OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Func_3_Invoke_mA2E67EB4D9947E4D56A2E7E2022D4A6D0BA37E90_gshared_inline (Func_3_tF03057D8F2223EA4C7E5EF1FABBE4CE367A43326* __this, RuntimeObject* ___0_arg1, int32_t ___1_arg2, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OperatorObserverBase_2_Dispose_m4FE9C0AD484389F1B7D7A6C9F7D28F8B3B7E407A_gshared (OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_mF7CEAE61925236C3A0BE9E92E9B97B65EF5DFFEF_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_m8B26C5F2B3AB3C05CB4ACDE5A17C6559BDEF503C_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 WorkSlice_1_get_Item_m31D876CE45C89B17D24E2D2EB6534C4150D72EE5_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, int32_t ___0_index, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_set_Item_m242025FA56F79603361582298B70AB2284A12067_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, int32_t ___0_index, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___1_value, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_length_mCDE5BAF472BC1BEBC9D091F532AC1A07D65DB0BC_gshared_inline (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_capacity_m514E3E1482974088A807521F9E2C481EB83C25F8_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Sorting_QuickSort_TisVector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_mB8556CFA6B9237741AAA1ADF2EE68AA3696F9477_gshared (Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_data, int32_t ___1_start, int32_t ___2_end, Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F* ___3_compare, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_Sort_m9DF994BABD5BF00DE8FEB14D82F7A0A9F6CAEE3D_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F* ___0_compare, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_mFEB81358558CEF0264CCE077535DB880EA2492BA_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_m7AC3CC7AABC83B76D23D2B94329DD4D0200156FA_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_get_Item_mFDEC427E08156ECD6879AD45AEE3618B43E3F726_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, int32_t ___0_index, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_set_Item_m757F8BE76FAE27C149DE7C474A2B1845E08A5A0F_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, int32_t ___0_index, Il2CppFullySharedGenericAny ___1_value, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_length_m7212817506EACBA1AB0D914DE401C6FA05F0DD9D_gshared_inline (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_capacity_mCF0D603B7EC6E6037D0E1A14D8D0F49AD063E59E_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_Sort_mE2ED392BDF8F4F4141D7BF4C984EFE943F607A94_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, Func_3_tECED1961B53AB164A131061296ABA1276B4FBBB9* ___0_compare, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_mC3BCAA8301A4E37DDB26811AAFFE1A3654FA47D0_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_m76CCC65E3DFB8B84A2154B65A79B56688F9B26A4_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 WorkSlice_1_get_Item_mFD8EE50B88077F3EF9BCEF97BD6D0352D2E8445D_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, int32_t ___0_index, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_set_Item_m070889CA2F62E82384BAB3CEF6D6E9AABF153663_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, int32_t ___0_index, LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 ___1_value, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_length_m0E5769CB5B052657E7327DCAD0F2CA104327D7D8_gshared_inline (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_capacity_m98A237D126494A11FF3C61211B36A790E4E8A3B0_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Sorting_QuickSort_TisLightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2_mD7019ED48D20810C1169430283118F96945E9450_gshared (LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___0_data, int32_t ___1_start, int32_t ___2_end, Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821* ___3_compare, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_Sort_m7EF532E936D55845DAAC606C0A214FE48EBF8584_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821* ___0_compare, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ExtractKeyDelegate_Invoke_m3214A3F92C2EB22088AB7738E8DFE1BE70925148_gshared_inline (ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* __this, RuntimeObject* ___0_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XHashtableState__ctor_m37E975C296D7D8CDF9ACAA9ABD7C4A0C82C427D3_gshared (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* ___0_extractKey, int32_t ___1_capacity, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtableState_TryAdd_m951A9A914307495745E2B33DB0BA6583FB4060A1_gshared (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, RuntimeObject* ___0_value, RuntimeObject** ___1_newValue, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t XHashtableState_ComputeHashCode_mD58A823B4A09F8DB93853EA9536E6B457B59F1B1_gshared (String_t* ___0_key, int32_t ___1_index, int32_t ___2_count, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtableState_FindEntry_m3AC0430564190D3FCAD9A8DB1DD0E725F7392A91_gshared (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, int32_t ___0_hashCode, String_t* ___1_key, int32_t ___2_index, int32_t ___3_count, int32_t* ___4_entryIndex, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtableState_TryGetValue_m22BFB31B1A4E2CEDE4CA7133F4A0B50B9E514308_gshared (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, String_t* ___0_key, int32_t ___1_index, int32_t ___2_count, RuntimeObject** ___3_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* XHashtableState_Resize_mDB3BA5C327EF6A86F6CE58B59E1D7430E62532C5_gshared (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, const RuntimeMethod* method) ;

inline void OperatorObserverBase_2__ctor_m6D849DC0DD5EE34A22139215AEB9594684813863 (OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method)
{
	((  void (*) (OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))OperatorObserverBase_2__ctor_m6D849DC0DD5EE34A22139215AEB9594684813863_gshared)(__this, ___0_observer, ___1_cancel, method);
}
inline bool Func_3_Invoke_mA2E67EB4D9947E4D56A2E7E2022D4A6D0BA37E90_inline (Func_3_tF03057D8F2223EA4C7E5EF1FABBE4CE367A43326* __this, RuntimeObject* ___0_arg1, int32_t ___1_arg2, const RuntimeMethod* method)
{
	return ((  bool (*) (Func_3_tF03057D8F2223EA4C7E5EF1FABBE4CE367A43326*, RuntimeObject*, int32_t, const RuntimeMethod*))Func_3_Invoke_mA2E67EB4D9947E4D56A2E7E2022D4A6D0BA37E90_gshared_inline)(__this, ___0_arg1, ___1_arg2, method);
}
inline void OperatorObserverBase_2_Dispose_m4FE9C0AD484389F1B7D7A6C9F7D28F8B3B7E407A (OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627* __this, const RuntimeMethod* method)
{
	((  void (*) (OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*, const RuntimeMethod*))OperatorObserverBase_2_Dispose_m4FE9C0AD484389F1B7D7A6C9F7D28F8B3B7E407A_gshared)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SingleAssignmentDisposable__ctor_mD18F9FC3F63F6FEBBA649E80A3B7DDE205A174C0 (SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SingleAssignmentDisposable_set_Disposable_mB73E42A9CEE96E39A067CF23EBD4F9DDD8F6F672 (SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE* __this, RuntimeObject* ___0_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* StableCompositeDisposable_Create_m5D5EAA49FB4EC4511BB1750B44E0836762530FC3 (RuntimeObject* ___0_disposable1, RuntimeObject* ___1_disposable2, const RuntimeMethod* method) ;
inline void WorkSlice_1__ctor_mF7CEAE61925236C3A0BE9E92E9B97B65EF5DFFEF (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*, int32_t, int32_t, const RuntimeMethod*))WorkSlice_1__ctor_mF7CEAE61925236C3A0BE9E92E9B97B65EF5DFFEF_gshared)(__this, ___0_src, ___1_srcStart, ___2_srcLen, method);
}
inline void WorkSlice_1__ctor_m8B26C5F2B3AB3C05CB4ACDE5A17C6559BDEF503C (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*, int32_t, const RuntimeMethod*))WorkSlice_1__ctor_m8B26C5F2B3AB3C05CB4ACDE5A17C6559BDEF503C_gshared)(__this, ___0_src, ___1_srcLen, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Math_Min_m53C488772A34D53917BCA2A491E79A0A5356ED52 (int32_t ___0_val1, int32_t ___1_val2, const RuntimeMethod* method) ;
inline Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 WorkSlice_1_get_Item_m31D876CE45C89B17D24E2D2EB6534C4150D72EE5 (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 (*) (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*, int32_t, const RuntimeMethod*))WorkSlice_1_get_Item_m31D876CE45C89B17D24E2D2EB6534C4150D72EE5_gshared)(__this, ___0_index, method);
}
inline void WorkSlice_1_set_Item_m242025FA56F79603361582298B70AB2284A12067 (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, int32_t ___0_index, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___1_value, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*, int32_t, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3, const RuntimeMethod*))WorkSlice_1_set_Item_m242025FA56F79603361582298B70AB2284A12067_gshared)(__this, ___0_index, ___1_value, method);
}
inline int32_t WorkSlice_1_get_length_mCDE5BAF472BC1BEBC9D091F532AC1A07D65DB0BC_inline (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*, const RuntimeMethod*))WorkSlice_1_get_length_mCDE5BAF472BC1BEBC9D091F532AC1A07D65DB0BC_gshared_inline)(__this, method);
}
inline int32_t WorkSlice_1_get_capacity_m514E3E1482974088A807521F9E2C481EB83C25F8 (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*, const RuntimeMethod*))WorkSlice_1_get_capacity_m514E3E1482974088A807521F9E2C481EB83C25F8_gshared)(__this, method);
}
inline void Sorting_QuickSort_TisVector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_mB8556CFA6B9237741AAA1ADF2EE68AA3696F9477 (Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_data, int32_t ___1_start, int32_t ___2_end, Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F* ___3_compare, const RuntimeMethod* method)
{
	((  void (*) (Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD*, int32_t, int32_t, Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F*, const RuntimeMethod*))Sorting_QuickSort_TisVector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_mB8556CFA6B9237741AAA1ADF2EE68AA3696F9477_gshared)(___0_data, ___1_start, ___2_end, ___3_compare, method);
}
inline void WorkSlice_1_Sort_m9DF994BABD5BF00DE8FEB14D82F7A0A9F6CAEE3D (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F* ___0_compare, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*, Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F*, const RuntimeMethod*))WorkSlice_1_Sort_m9DF994BABD5BF00DE8FEB14D82F7A0A9F6CAEE3D_gshared)(__this, ___0_compare, method);
}
inline void WorkSlice_1__ctor_mFEB81358558CEF0264CCE077535DB880EA2492BA (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC*, int32_t, const RuntimeMethod*))WorkSlice_1__ctor_mFEB81358558CEF0264CCE077535DB880EA2492BA_gshared)(__this, ___0_src, ___1_srcLen, method);
}
inline void WorkSlice_1__ctor_m7AC3CC7AABC83B76D23D2B94329DD4D0200156FA (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC*, int32_t, int32_t, const RuntimeMethod*))WorkSlice_1__ctor_m7AC3CC7AABC83B76D23D2B94329DD4D0200156FA_gshared)(__this, ___0_src, ___1_srcStart, ___2_srcLen, method);
}
inline void WorkSlice_1_get_Item_mFDEC427E08156ECD6879AD45AEE3618B43E3F726 (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, int32_t ___0_index, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*, int32_t, Il2CppFullySharedGenericAny*, const RuntimeMethod*))WorkSlice_1_get_Item_mFDEC427E08156ECD6879AD45AEE3618B43E3F726_gshared)((WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*)__this, ___0_index, il2cppRetVal, method);
}
inline void WorkSlice_1_set_Item_m757F8BE76FAE27C149DE7C474A2B1845E08A5A0F (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, int32_t ___0_index, Il2CppFullySharedGenericAny ___1_value, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*, int32_t, Il2CppFullySharedGenericAny, const RuntimeMethod*))WorkSlice_1_set_Item_m757F8BE76FAE27C149DE7C474A2B1845E08A5A0F_gshared)((WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*)__this, ___0_index, ___1_value, method);
}
inline int32_t WorkSlice_1_get_length_m7212817506EACBA1AB0D914DE401C6FA05F0DD9D_inline (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*, const RuntimeMethod*))WorkSlice_1_get_length_m7212817506EACBA1AB0D914DE401C6FA05F0DD9D_gshared_inline)(__this, method);
}
inline int32_t WorkSlice_1_get_capacity_mCF0D603B7EC6E6037D0E1A14D8D0F49AD063E59E (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*, const RuntimeMethod*))WorkSlice_1_get_capacity_mCF0D603B7EC6E6037D0E1A14D8D0F49AD063E59E_gshared)(__this, method);
}
inline void WorkSlice_1_Sort_mE2ED392BDF8F4F4141D7BF4C984EFE943F607A94 (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, Func_3_tECED1961B53AB164A131061296ABA1276B4FBBB9* ___0_compare, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*, Func_3_tECED1961B53AB164A131061296ABA1276B4FBBB9*, const RuntimeMethod*))WorkSlice_1_Sort_mE2ED392BDF8F4F4141D7BF4C984EFE943F607A94_gshared)(__this, ___0_compare, method);
}
inline void WorkSlice_1__ctor_mC3BCAA8301A4E37DDB26811AAFFE1A3654FA47D0 (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*, LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263*, int32_t, int32_t, const RuntimeMethod*))WorkSlice_1__ctor_mC3BCAA8301A4E37DDB26811AAFFE1A3654FA47D0_gshared)(__this, ___0_src, ___1_srcStart, ___2_srcLen, method);
}
inline void WorkSlice_1__ctor_m76CCC65E3DFB8B84A2154B65A79B56688F9B26A4 (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*, LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263*, int32_t, const RuntimeMethod*))WorkSlice_1__ctor_m76CCC65E3DFB8B84A2154B65A79B56688F9B26A4_gshared)(__this, ___0_src, ___1_srcLen, method);
}
inline LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 WorkSlice_1_get_Item_mFD8EE50B88077F3EF9BCEF97BD6D0352D2E8445D (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 (*) (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*, int32_t, const RuntimeMethod*))WorkSlice_1_get_Item_mFD8EE50B88077F3EF9BCEF97BD6D0352D2E8445D_gshared)(__this, ___0_index, method);
}
inline void WorkSlice_1_set_Item_m070889CA2F62E82384BAB3CEF6D6E9AABF153663 (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, int32_t ___0_index, LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 ___1_value, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*, int32_t, LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2, const RuntimeMethod*))WorkSlice_1_set_Item_m070889CA2F62E82384BAB3CEF6D6E9AABF153663_gshared)(__this, ___0_index, ___1_value, method);
}
inline int32_t WorkSlice_1_get_length_m0E5769CB5B052657E7327DCAD0F2CA104327D7D8_inline (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*, const RuntimeMethod*))WorkSlice_1_get_length_m0E5769CB5B052657E7327DCAD0F2CA104327D7D8_gshared_inline)(__this, method);
}
inline int32_t WorkSlice_1_get_capacity_m98A237D126494A11FF3C61211B36A790E4E8A3B0 (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*, const RuntimeMethod*))WorkSlice_1_get_capacity_m98A237D126494A11FF3C61211B36A790E4E8A3B0_gshared)(__this, method);
}
inline void Sorting_QuickSort_TisLightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2_mD7019ED48D20810C1169430283118F96945E9450 (LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___0_data, int32_t ___1_start, int32_t ___2_end, Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821* ___3_compare, const RuntimeMethod* method)
{
	((  void (*) (LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263*, int32_t, int32_t, Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821*, const RuntimeMethod*))Sorting_QuickSort_TisLightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2_mD7019ED48D20810C1169430283118F96945E9450_gshared)(___0_data, ___1_start, ___2_end, ___3_compare, method);
}
inline void WorkSlice_1_Sort_m7EF532E936D55845DAAC606C0A214FE48EBF8584 (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821* ___0_compare, const RuntimeMethod* method)
{
	((  void (*) (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*, Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821*, const RuntimeMethod*))WorkSlice_1_Sort_m7EF532E936D55845DAAC606C0A214FE48EBF8584_gshared)(__this, ___0_compare, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Interlocked_CompareExchange_mB06E8737D3DA41F9FFBC38A6D0583D515EFB5717 (int32_t* ___0_location1, int32_t ___1_value, int32_t ___2_comparand, const RuntimeMethod* method) ;
inline String_t* ExtractKeyDelegate_Invoke_m3214A3F92C2EB22088AB7738E8DFE1BE70925148_inline (ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* __this, RuntimeObject* ___0_value, const RuntimeMethod* method)
{
	return ((  String_t* (*) (ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583*, RuntimeObject*, const RuntimeMethod*))ExtractKeyDelegate_Invoke_m3214A3F92C2EB22088AB7738E8DFE1BE70925148_gshared_inline)(__this, ___0_value, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OverflowException__ctor_m7F6A928C9BE47384586BDDE8B4B87666421E0F1A (OverflowException_t6F6AD8CACE20C37F701C05B373A215C4802FAB0C* __this, const RuntimeMethod* method) ;
inline void XHashtableState__ctor_m37E975C296D7D8CDF9ACAA9ABD7C4A0C82C427D3 (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* ___0_extractKey, int32_t ___1_capacity, const RuntimeMethod* method)
{
	((  void (*) (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A*, ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583*, int32_t, const RuntimeMethod*))XHashtableState__ctor_m37E975C296D7D8CDF9ACAA9ABD7C4A0C82C427D3_gshared)(__this, ___0_extractKey, ___1_capacity, method);
}
inline bool XHashtableState_TryAdd_m951A9A914307495745E2B33DB0BA6583FB4060A1 (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, RuntimeObject* ___0_value, RuntimeObject** ___1_newValue, const RuntimeMethod* method)
{
	return ((  bool (*) (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A*, RuntimeObject*, RuntimeObject**, const RuntimeMethod*))XHashtableState_TryAdd_m951A9A914307495745E2B33DB0BA6583FB4060A1_gshared)(__this, ___0_value, ___1_newValue, method);
}
inline int32_t XHashtableState_ComputeHashCode_mD58A823B4A09F8DB93853EA9536E6B457B59F1B1 (String_t* ___0_key, int32_t ___1_index, int32_t ___2_count, const RuntimeMethod* method)
{
	return ((  int32_t (*) (String_t*, int32_t, int32_t, const RuntimeMethod*))XHashtableState_ComputeHashCode_mD58A823B4A09F8DB93853EA9536E6B457B59F1B1_gshared)(___0_key, ___1_index, ___2_count, method);
}
inline bool XHashtableState_FindEntry_m3AC0430564190D3FCAD9A8DB1DD0E725F7392A91 (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, int32_t ___0_hashCode, String_t* ___1_key, int32_t ___2_index, int32_t ___3_count, int32_t* ___4_entryIndex, const RuntimeMethod* method)
{
	return ((  bool (*) (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A*, int32_t, String_t*, int32_t, int32_t, int32_t*, const RuntimeMethod*))XHashtableState_FindEntry_m3AC0430564190D3FCAD9A8DB1DD0E725F7392A91_gshared)(__this, ___0_hashCode, ___1_key, ___2_index, ___3_count, ___4_entryIndex, method);
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Interlocked_Increment_m3C240C32E8D9544EC050B74D4F28EEB58F1F9309 (int32_t* ___0_location, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Thread_MemoryBarrier_m83873F1E6CEB16C0781941141382DA874A36097D (const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t String_CompareOrdinal_m8940CFAE90021ED8DA3F2DF8226941C9EEB2E32D (String_t* ___0_strA, int32_t ___1_indexA, String_t* ___2_strB, int32_t ___3_indexB, int32_t ___4_length, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3 (String_t* __this, int32_t ___0_index, const RuntimeMethod* method) ;
inline bool XHashtableState_TryGetValue_m22BFB31B1A4E2CEDE4CA7133F4A0B50B9E514308 (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, String_t* ___0_key, int32_t ___1_index, int32_t ___2_count, RuntimeObject** ___3_value, const RuntimeMethod* method)
{
	return ((  bool (*) (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A*, String_t*, int32_t, int32_t, RuntimeObject**, const RuntimeMethod*))XHashtableState_TryGetValue_m22BFB31B1A4E2CEDE4CA7133F4A0B50B9E514308_gshared)(__this, ___0_key, ___1_index, ___2_count, ___3_value, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA (RuntimeObject* ___0_obj, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149 (RuntimeObject* ___0_obj, bool* ___1_lockTaken, const RuntimeMethod* method) ;
inline XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* XHashtableState_Resize_mDB3BA5C327EF6A86F6CE58B59E1D7430E62532C5 (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, const RuntimeMethod* method)
{
	return ((  XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* (*) (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A*, const RuntimeMethod*))XHashtableState_Resize_mDB3BA5C327EF6A86F6CE58B59E1D7430E62532C5_gshared)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action__ctor_mBDC7B0B4A3F583B64C2896F01BDED360772F67DC (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Disposable_Create_m8FC5E161705A5AB1D0FD89067783648C9A6B1BF1 (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___0_disposeAction, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* StableCompositeDisposable_CreateUnsafe_m61E9E95FD914CF4A0EB267CBE46D63AB1066FD08 (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* ___0_disposables, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* StableCompositeDisposable_Create_m69159E99C420E2BBE360CC54400E67127D36E724 (RuntimeObject* ___0_disposable1, RuntimeObject* ___1_disposable2, RuntimeObject* ___2_disposable3, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* StableCompositeDisposable_Create_mEF2811969D2F81FD06130ED8A4A48D26E42F9B94 (RuntimeObject* ___0_disposable1, RuntimeObject* ___1_disposable2, RuntimeObject* ___2_disposable3, RuntimeObject* ___3_disposable4, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* StableCompositeDisposable_Create_mFC6500B00F009673E99112947958DF4058759242 (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* ___0_disposables, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Clear_m50BAA3751899858B097D3FF2ED31F284703FE5CB (RuntimeArray* ___0_array, int32_t ___1_index, int32_t ___2_length, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80888
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Where___ctor_mA693A68D9AE18C5CFEACEB44E2FA38C36304FA83_gshared (Where__t5104F30F0CF1DB24C11737FBAF6AE85C06330FB8* __this, WhereObservable_1_t3ED825243E1FF00921A3F094DE46F8E1636EF293* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:111>
		RuntimeObject* L_0 = ___1_observer;
		RuntimeObject* L_1 = ___2_cancel;
		OperatorObserverBase_2__ctor_m6D849DC0DD5EE34A22139215AEB9594684813863((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:113>
		WhereObservable_1_t3ED825243E1FF00921A3F094DE46F8E1636EF293* L_2 = ___0_parent;
		__this->___parent = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:114>
		__this->___index = 0;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:115>
		return;
	}
}
// Method Definition Index: 80889
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Where__OnNext_m981C1D8949EBB063A92AED4F1A7F9075614E8FA2_gshared (Where__t5104F30F0CF1DB24C11737FBAF6AE85C06330FB8* __this, RuntimeObject* ___0_value, const RuntimeMethod* method) 
{
	bool V_0 = false;
	int32_t V_1 = 0;
	Exception_t* V_2 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:119>
		V_0 = (bool)0;
	}
	try
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:122>
		WhereObservable_1_t3ED825243E1FF00921A3F094DE46F8E1636EF293* L_0 = __this->___parent;
		NullCheck(L_0);
		Func_3_tF03057D8F2223EA4C7E5EF1FABBE4CE367A43326* L_1 = L_0->___predicateWithIndex;
		RuntimeObject* L_2 = ___0_value;
		int32_t L_3 = __this->___index;
		V_1 = L_3;
		int32_t L_4 = V_1;
		__this->___index = ((int32_t)il2cpp_codegen_add(L_4, 1));
		int32_t L_5 = V_1;
		NullCheck(L_1);
		bool L_6;
		L_6 = Func_3_Invoke_mA2E67EB4D9947E4D56A2E7E2022D4A6D0BA37E90_inline(L_1, L_2, L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		V_0 = L_6;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:123>
		goto IL_0041;
	}
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0027;
		}
		throw e;
	}

CATCH_0027:
	{
		{
			Exception_t* L_7 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));;
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:124>
			V_2 = L_7;
		}
		{
			auto __finallyBlock = il2cpp::utils::Finally([&]
			{

FINALLY_0038:
				{
					//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:126>
					NullCheck((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this);
					OperatorObserverBase_2_Dispose_m4FE9C0AD484389F1B7D7A6C9F7D28F8B3B7E407A((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
					//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:126>
					return;
				}
			});
			try
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:126>
				RuntimeObject* L_8 = ((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this)->___observer;
				il2cpp_codegen_memory_barrier();
				Exception_t* L_9 = V_2;
				NullCheck(L_8);
				InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 0), L_8, L_9);
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:126>
				goto IL_003f;
			}
			catch(Il2CppExceptionWrapper& e)
			{
				__finallyBlock.StoreException(e.ex);
			}
		}

IL_003f:
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:127>
			IL2CPP_POP_ACTIVE_EXCEPTION(Exception_t*);
			goto IL_0052;
		}
	}

IL_0041:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:130>
		bool L_10 = V_0;
		if (!L_10)
		{
			goto IL_0052;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:132>
		RuntimeObject* L_11 = ((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		RuntimeObject* L_12 = ___0_value;
		NullCheck(L_11);
		InterfaceActionInvoker1< RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 0), L_11, L_12);
	}

IL_0052:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:134>
		return;
	}
}
// Method Definition Index: 80890
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Where__OnError_m1DEBA46E90305F1F07346D15A8E45C48E99A94D0_gshared (Where__t5104F30F0CF1DB24C11737FBAF6AE85C06330FB8* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:138>
				NullCheck((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this);
				OperatorObserverBase_2_Dispose_m4FE9C0AD484389F1B7D7A6C9F7D28F8B3B7E407A((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:138>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:138>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 0), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:138>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:139>
		return;
	}
}
// Method Definition Index: 80891
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Where__OnCompleted_m36475B4AF6919EF477621BAC4136ACAEBD8B7A0F_gshared (Where__t5104F30F0CF1DB24C11737FBAF6AE85C06330FB8* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:143>
				NullCheck((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this);
				OperatorObserverBase_2_Dispose_m4FE9C0AD484389F1B7D7A6C9F7D28F8B3B7E407A((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:143>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:143>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tF90516AE32C24262B9CCFA04086E6036E8129627*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 0), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:143>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:144>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80888
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Where___ctor_mB43425063318B62AB672F302CD61D075D7DF5C12_gshared (Where__tC1CFF1B49CFDEDB8F32C86A7A354330BD141B79C* __this, WhereObservable_1_tAEF5B968677E7DD944B72065B689C7D6D0F557A0* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:111>
		RuntimeObject* L_0 = ___1_observer;
		RuntimeObject* L_1 = ___2_cancel;
		((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:113>
		WhereObservable_1_tAEF5B968677E7DD944B72065B689C7D6D0F557A0* L_2 = ___0_parent;
		__this->___parent = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:114>
		__this->___index = 0;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:115>
		return;
	}
}
// Method Definition Index: 80889
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Where__OnNext_m02ABD860C13A37082F170A02D8D73938CA0B55C7_gshared (Where__tC1CFF1B49CFDEDB8F32C86A7A354330BD141B79C* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_T_tAF0D5901E1EA6C8B7461DCADD3330BA640C38963 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 6));
	const Il2CppFullySharedGenericAny L_2 = alloca(SizeOf_T_tAF0D5901E1EA6C8B7461DCADD3330BA640C38963);
	const Il2CppFullySharedGenericAny L_12 = L_2;
	bool V_0 = false;
	int32_t V_1 = 0;
	Exception_t* V_2 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:119>
		V_0 = (bool)0;
	}
	try
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:122>
		WhereObservable_1_tAEF5B968677E7DD944B72065B689C7D6D0F557A0* L_0 = __this->___parent;
		NullCheck(L_0);
		Func_3_tDADD7F9B266FDB16BDFFC46D6D5A79E7EA04406E* L_1 = L_0->___predicateWithIndex;
		il2cpp_codegen_memcpy(L_2, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 6)) ? ___0_value : &___0_value), SizeOf_T_tAF0D5901E1EA6C8B7461DCADD3330BA640C38963);
		int32_t L_3 = __this->___index;
		V_1 = L_3;
		int32_t L_4 = V_1;
		__this->___index = ((int32_t)il2cpp_codegen_add(L_4, 1));
		int32_t L_5 = V_1;
		NullCheck(L_1);
		bool L_6;
		L_6 = InvokerFuncInvoker2< bool, Il2CppFullySharedGenericAny, int32_t >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)), il2cpp_rgctx_method(method->klass->rgctx_data, 7), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 6)) ? L_2: *(void**)L_2), L_5);
		V_0 = L_6;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:123>
		goto IL_0041;
	}
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0027;
		}
		throw e;
	}

CATCH_0027:
	{
		{
			Exception_t* L_7 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));;
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:124>
			V_2 = L_7;
		}
		{
			auto __finallyBlock = il2cpp::utils::Finally([&]
			{

FINALLY_0038:
				{
					//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:126>
					NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
					((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
					//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:126>
					return;
				}
			});
			try
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:126>
				RuntimeObject* L_8 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
				il2cpp_codegen_memory_barrier();
				Exception_t* L_9 = V_2;
				NullCheck(L_8);
				InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 0), L_8, L_9);
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:126>
				goto IL_003f;
			}
			catch(Il2CppExceptionWrapper& e)
			{
				__finallyBlock.StoreException(e.ex);
			}
		}

IL_003f:
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:127>
			IL2CPP_POP_ACTIVE_EXCEPTION(Exception_t*);
			goto IL_0052;
		}
	}

IL_0041:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:130>
		bool L_10 = V_0;
		if (!L_10)
		{
			goto IL_0052;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:132>
		RuntimeObject* L_11 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_12, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 6)) ? ___0_value : &___0_value), SizeOf_T_tAF0D5901E1EA6C8B7461DCADD3330BA640C38963);
		NullCheck(L_11);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 0), L_11, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 6)) ? L_12: *(void**)L_12));
	}

IL_0052:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:134>
		return;
	}
}
// Method Definition Index: 80890
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Where__OnError_m5BCD9A29560E003FD09854E0AC68B010197A5694_gshared (Where__tC1CFF1B49CFDEDB8F32C86A7A354330BD141B79C* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:138>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:138>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:138>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 0), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:138>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:139>
		return;
	}
}
// Method Definition Index: 80891
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Where__OnCompleted_mD434ED3D661515B7E18B717162FB72EB85F96FB7_gshared (Where__tC1CFF1B49CFDEDB8F32C86A7A354330BD141B79C* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:143>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:143>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:143>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 0), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:143>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Where.cs:144>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80902
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WithLatestFrom__ctor_m4A9C9A8E6F8E158C3082D2890E523AC4C681DE81_gshared (WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4* __this, WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:30>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		il2cpp_codegen_write_instance_field_data<RuntimeObject*>(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),1), L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:35>
		RuntimeObject* L_1 = ___1_observer;
		RuntimeObject* L_2 = ___2_cancel;
		((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, L_1, L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:37>
		WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885* L_3 = ___0_parent;
		il2cpp_codegen_write_instance_field_data<WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885*>(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0), L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:38>
		return;
	}
}
// Method Definition Index: 80903
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WithLatestFrom_Run_m9BAEBB94073033DDE38785CCD1BB25843866B55E_gshared (WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE* V_0 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:42>
		WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885* L_0 = *(WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0));
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->___left;
		LeftObserver_tBD9CC4BC709982E0C2956F9F65443C863A5055BE* L_2 = (LeftObserver_tBD9CC4BC709982E0C2956F9F65443C863A5055BE*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 6));
		((  void (*) (LeftObserver_tBD9CC4BC709982E0C2956F9F65443C863A5055BE*, WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_2, __this, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		NullCheck(L_1);
		RuntimeObject* L_3;
		L_3 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 5), L_1, (RuntimeObject*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:43>
		SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE* L_4 = (SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE*)il2cpp_codegen_object_new(SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE_il2cpp_TypeInfo_var);
		SingleAssignmentDisposable__ctor_mD18F9FC3F63F6FEBBA649E80A3B7DDE205A174C0(L_4, NULL);
		V_0 = L_4;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:44>
		SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE* L_5 = V_0;
		WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885* L_6 = *(WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0));
		NullCheck(L_6);
		RuntimeObject* L_7 = L_6->___right;
		SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE* L_8 = V_0;
		RightObserver_tD89649C363EBB9D55FD41D18A2603BE0282C6FBE* L_9 = (RightObserver_tD89649C363EBB9D55FD41D18A2603BE0282C6FBE*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 11));
		((  void (*) (RightObserver_tD89649C363EBB9D55FD41D18A2603BE0282C6FBE*, WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))(L_9, __this, (RuntimeObject*)L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		NullCheck(L_7);
		RuntimeObject* L_10;
		L_10 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 10), L_7, (RuntimeObject*)L_9);
		NullCheck(L_5);
		SingleAssignmentDisposable_set_Disposable_mB73E42A9CEE96E39A067CF23EBD4F9DDD8F6F672(L_5, L_10, NULL);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:46>
		SingleAssignmentDisposable_tBC7303F46AEDD910009E3D72DD7458862FA7E1FE* L_11 = V_0;
		RuntimeObject* L_12;
		L_12 = StableCompositeDisposable_Create_m5D5EAA49FB4EC4511BB1750B44E0836762530FC3(L_3, (RuntimeObject*)L_11, NULL);
		return (RuntimeObject*)L_12;
	}
}
// Method Definition Index: 80904
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WithLatestFrom_OnNext_mDFAD498950658579A3B68FD4AC470DED798E5F21_gshared (WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TResult_t19EDD6F703CC0D3C63679F268516A40C787C0F62 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 17));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TResult_t19EDD6F703CC0D3C63679F268516A40C787C0F62);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:51>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 17)) ? ___0_value : &___0_value), SizeOf_TResult_t19EDD6F703CC0D3C63679F268516A40C787C0F62);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 17)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:52>
		return;
	}
}
// Method Definition Index: 80905
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WithLatestFrom_OnError_m64EA8EC3C84884AB77429BF323C6E6C67661C2DB_gshared (WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:57>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 20)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 20));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:57>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:56>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:56>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:58>
		return;
	}
}
// Method Definition Index: 80906
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WithLatestFrom_OnCompleted_m04E2E510407F8F06142A2CCF5BAE86FD9EF35C26_gshared (WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:63>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 20)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 20));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:63>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:62>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:62>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:64>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80900
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WithLatestFromObservable_3__ctor_m0AC5FC569C443CFD90C03493E1080E4443913F19_gshared (WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885* __this, RuntimeObject* ___0_left, RuntimeObject* ___1_right, Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* ___2_selector, const RuntimeMethod* method) 
{
	WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885* G_B2_0 = NULL;
	WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885* G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885* G_B3_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:15>
		RuntimeObject* L_0 = ___0_left;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B2_0 = __this;
			goto IL_0011;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_right;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		G_B3_0 = ((int32_t)(L_3));
		G_B3_1 = G_B1_0;
		goto IL_0012;
	}

IL_0011:
	{
		G_B3_0 = 1;
		G_B3_1 = G_B2_0;
	}

IL_0012:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 4)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B3_1, (bool)G_B3_0, il2cpp_rgctx_method(method->klass->rgctx_data, 4));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:17>
		RuntimeObject* L_4 = ___0_left;
		__this->___left = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___left), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:18>
		RuntimeObject* L_5 = ___1_right;
		__this->___right = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___right), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:19>
		Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* L_6 = ___2_selector;
		__this->___selector = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___selector), (void*)L_6);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:20>
		return;
	}
}
// Method Definition Index: 80901
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WithLatestFromObservable_3_SubscribeCore_mFF832DB6668FAFA6DE7EC164D107C54B9653047F_gshared (WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/WithLatestFrom.cs:24>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4* L_2 = (WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 9));
		((  void (*) (WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4*, WithLatestFromObservable_3_t323A42B66EB51D082F0A7A2AC453A719DFAC1885*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))(L_2, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (WithLatestFrom_tCE9E84AA570D2175EB47243D70FCE0A4A8A628B4*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 74022
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WithoutCurrentEnumerable__ctor_m5F2548C9BDEA098E43955DB9F5AB9AC9867A1446_gshared (WithoutCurrentEnumerable_t61691720F7363FB52D0166233D6F1CDEC9A12368* __this, AsyncReactiveProperty_1_t55DCE046DB85F4B8B8BFAD7AE879EE536D5F9733* ___0_parent, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.cysharp.unitask@a85b92a8e443/Runtime/AsyncReactiveProperty.cs:218>
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2((RuntimeObject*)__this, NULL);
		//<source_info:./Library/PackageCache/com.cysharp.unitask@a85b92a8e443/Runtime/AsyncReactiveProperty.cs:220>
		AsyncReactiveProperty_1_t55DCE046DB85F4B8B8BFAD7AE879EE536D5F9733* L_0 = ___0_parent;
		__this->___parent = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_0);
		//<source_info:./Library/PackageCache/com.cysharp.unitask@a85b92a8e443/Runtime/AsyncReactiveProperty.cs:221>
		return;
	}
}
// Method Definition Index: 74023
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WithoutCurrentEnumerable_GetAsyncEnumerator_mA34590B1BE46B1BCA23E0AFE548A2B8EEC33788B_gshared (WithoutCurrentEnumerable_t61691720F7363FB52D0166233D6F1CDEC9A12368* __this, CancellationToken_t51142D9C6D7C02D314DA34A6A7988C528992FFED ___0_cancellationToken, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.cysharp.unitask@a85b92a8e443/Runtime/AsyncReactiveProperty.cs:225>
		AsyncReactiveProperty_1_t55DCE046DB85F4B8B8BFAD7AE879EE536D5F9733* L_0 = __this->___parent;
		CancellationToken_t51142D9C6D7C02D314DA34A6A7988C528992FFED L_1 = ___0_cancellationToken;
		Enumerator_t52AB038CB588CDE841350C02AA5D28DAAA6DBA60* L_2 = (Enumerator_t52AB038CB588CDE841350C02AA5D28DAAA6DBA60*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 2));
		((  void (*) (Enumerator_t52AB038CB588CDE841350C02AA5D28DAAA6DBA60*, AsyncReactiveProperty_1_t55DCE046DB85F4B8B8BFAD7AE879EE536D5F9733*, CancellationToken_t51142D9C6D7C02D314DA34A6A7988C528992FFED, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, L_0, L_1, (bool)0, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		return (RuntimeObject*)L_2;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 74071
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WithoutCurrentEnumerable__ctor_m4C8C640AF658BB633522AD90FBFFFD2A4C742B2C_gshared (WithoutCurrentEnumerable_tA165573F50CE7FD8626E075AE98BC04DE9B29888* __this, ReadOnlyAsyncReactiveProperty_1_tB7349A20B00D8047434C5CDE4CB7EC263380B1E9* ___0_parent, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.cysharp.unitask@a85b92a8e443/Runtime/AsyncReactiveProperty.cs:536>
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2((RuntimeObject*)__this, NULL);
		//<source_info:./Library/PackageCache/com.cysharp.unitask@a85b92a8e443/Runtime/AsyncReactiveProperty.cs:538>
		ReadOnlyAsyncReactiveProperty_1_tB7349A20B00D8047434C5CDE4CB7EC263380B1E9* L_0 = ___0_parent;
		__this->___parent = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_0);
		//<source_info:./Library/PackageCache/com.cysharp.unitask@a85b92a8e443/Runtime/AsyncReactiveProperty.cs:539>
		return;
	}
}
// Method Definition Index: 74072
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WithoutCurrentEnumerable_GetAsyncEnumerator_mF8EB8E275666D4F8CB9E5DB7DA08CF20E14A833C_gshared (WithoutCurrentEnumerable_tA165573F50CE7FD8626E075AE98BC04DE9B29888* __this, CancellationToken_t51142D9C6D7C02D314DA34A6A7988C528992FFED ___0_cancellationToken, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.cysharp.unitask@a85b92a8e443/Runtime/AsyncReactiveProperty.cs:543>
		ReadOnlyAsyncReactiveProperty_1_tB7349A20B00D8047434C5CDE4CB7EC263380B1E9* L_0 = __this->___parent;
		CancellationToken_t51142D9C6D7C02D314DA34A6A7988C528992FFED L_1 = ___0_cancellationToken;
		Enumerator_t2264BA8CF3D7072C596172D20E9E9AB2BF7CF0BE* L_2 = (Enumerator_t2264BA8CF3D7072C596172D20E9E9AB2BF7CF0BE*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 2));
		((  void (*) (Enumerator_t2264BA8CF3D7072C596172D20E9E9AB2BF7CF0BE*, ReadOnlyAsyncReactiveProperty_1_tB7349A20B00D8047434C5CDE4CB7EC263380B1E9*, CancellationToken_t51142D9C6D7C02D314DA34A6A7988C528992FFED, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, L_0, L_1, (bool)0, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		return (RuntimeObject*)L_2;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 55219
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_m8B26C5F2B3AB3C05CB4ACDE5A17C6559BDEF503C_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:108>
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_0 = ___0_src;
		int32_t L_1 = ___1_srcLen;
		WorkSlice_1__ctor_mF7CEAE61925236C3A0BE9E92E9B97B65EF5DFFEF(__this, L_0, 0, L_1, il2cpp_rgctx_method(InitializedTypeInfo(method->klass)->rgctx_data, 1));
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:108>
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1__ctor_m8B26C5F2B3AB3C05CB4ACDE5A17C6559BDEF503C_AdjustorThunk (RuntimeObject* __this, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method)
{
	WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*>(__this + _offset);
	WorkSlice_1__ctor_m8B26C5F2B3AB3C05CB4ACDE5A17C6559BDEF503C(_thisAdjusted, ___0_src, ___1_srcLen, method);
}
// Method Definition Index: 55220
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_mF7CEAE61925236C3A0BE9E92E9B97B65EF5DFFEF_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* G_B2_0 = NULL;
	WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* G_B3_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:112>
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_0 = ___0_src;
		__this->___m_Data = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_Data), (void*)L_0);
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:113>
		int32_t L_1 = ___1_srcStart;
		__this->___m_Start = L_1;
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:114>
		int32_t L_2 = ___2_srcLen;
		if ((((int32_t)L_2) < ((int32_t)0)))
		{
			G_B2_0 = __this;
			goto IL_001e;
		}
		G_B1_0 = __this;
	}
	{
		int32_t L_3 = ___2_srcLen;
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_4 = ___0_src;
		NullCheck(L_4);
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		int32_t L_5;
		L_5 = Math_Min_m53C488772A34D53917BCA2A491E79A0A5356ED52(L_3, ((int32_t)(((RuntimeArray*)L_4)->max_length)), NULL);
		G_B3_0 = L_5;
		G_B3_1 = G_B1_0;
		goto IL_0021;
	}

IL_001e:
	{
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_6 = ___0_src;
		NullCheck(L_6);
		G_B3_0 = ((int32_t)(((RuntimeArray*)L_6)->max_length));
		G_B3_1 = G_B2_0;
	}

IL_0021:
	{
		G_B3_1->___m_Length = G_B3_0;
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:116>
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1__ctor_mF7CEAE61925236C3A0BE9E92E9B97B65EF5DFFEF_AdjustorThunk (RuntimeObject* __this, Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method)
{
	WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*>(__this + _offset);
	WorkSlice_1__ctor_mF7CEAE61925236C3A0BE9E92E9B97B65EF5DFFEF(_thisAdjusted, ___0_src, ___1_srcStart, ___2_srcLen, method);
}
// Method Definition Index: 55221
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 WorkSlice_1_get_Item_m31D876CE45C89B17D24E2D2EB6534C4150D72EE5_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:120>
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_0 = __this->___m_Data;
		int32_t L_1 = __this->___m_Start;
		int32_t L_2 = ___0_index;
		NullCheck(L_0);
		int32_t L_3 = ((int32_t)il2cpp_codegen_add(L_1, L_2));
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_4 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		return L_4;
	}
}
IL2CPP_EXTERN_C  Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 WorkSlice_1_get_Item_m31D876CE45C89B17D24E2D2EB6534C4150D72EE5_AdjustorThunk (RuntimeObject* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*>(__this + _offset);
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 _returnValue;
	_returnValue = WorkSlice_1_get_Item_m31D876CE45C89B17D24E2D2EB6534C4150D72EE5(_thisAdjusted, ___0_index, method);
	return _returnValue;
}
// Method Definition Index: 55222
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_set_Item_m242025FA56F79603361582298B70AB2284A12067_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, int32_t ___0_index, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___1_value, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:121>
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_0 = __this->___m_Data;
		int32_t L_1 = __this->___m_Start;
		int32_t L_2 = ___0_index;
		Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 L_3 = ___1_value;
		NullCheck(L_0);
		(L_0)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_1, L_2))), (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3)L_3);
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1_set_Item_m242025FA56F79603361582298B70AB2284A12067_AdjustorThunk (RuntimeObject* __this, int32_t ___0_index, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___1_value, const RuntimeMethod* method)
{
	WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*>(__this + _offset);
	WorkSlice_1_set_Item_m242025FA56F79603361582298B70AB2284A12067(_thisAdjusted, ___0_index, ___1_value, method);
}
// Method Definition Index: 55223
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_length_mCDE5BAF472BC1BEBC9D091F532AC1A07D65DB0BC_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:124>
		int32_t L_0 = __this->___m_Length;
		return L_0;
	}
}
IL2CPP_EXTERN_C  int32_t WorkSlice_1_get_length_mCDE5BAF472BC1BEBC9D091F532AC1A07D65DB0BC_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = WorkSlice_1_get_length_mCDE5BAF472BC1BEBC9D091F532AC1A07D65DB0BC_inline(_thisAdjusted, method);
	return _returnValue;
}
// Method Definition Index: 55224
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_capacity_m514E3E1482974088A807521F9E2C481EB83C25F8_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:125>
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_0 = __this->___m_Data;
		NullCheck(L_0);
		return ((int32_t)(((RuntimeArray*)L_0)->max_length));
	}
}
IL2CPP_EXTERN_C  int32_t WorkSlice_1_get_capacity_m514E3E1482974088A807521F9E2C481EB83C25F8_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = WorkSlice_1_get_capacity_m514E3E1482974088A807521F9E2C481EB83C25F8(_thisAdjusted, method);
	return _returnValue;
}
// Method Definition Index: 55225
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_Sort_m9DF994BABD5BF00DE8FEB14D82F7A0A9F6CAEE3D_gshared (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F* ___0_compare, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Sorting_tBB4ACAADCAA21EA710DD3998A0614ABDEF8FD8A6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:129>
		int32_t L_0 = __this->___m_Length;
		if ((((int32_t)L_0) <= ((int32_t)1)))
		{
			goto IL_002a;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:130>
		Vector4U5BU5D_tC0F3A7115F85007510F6D173968200CD31BCF7AD* L_1 = __this->___m_Data;
		int32_t L_2 = __this->___m_Start;
		int32_t L_3 = __this->___m_Start;
		int32_t L_4 = __this->___m_Length;
		Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F* L_5 = ___0_compare;
		il2cpp_codegen_runtime_class_init_inline(Sorting_tBB4ACAADCAA21EA710DD3998A0614ABDEF8FD8A6_il2cpp_TypeInfo_var);
		Sorting_QuickSort_TisVector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3_mB8556CFA6B9237741AAA1ADF2EE68AA3696F9477(L_1, L_2, ((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_3, L_4)), 1)), L_5, il2cpp_rgctx_method(InitializedTypeInfo(method->klass)->rgctx_data, 6));
	}

IL_002a:
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:131>
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1_Sort_m9DF994BABD5BF00DE8FEB14D82F7A0A9F6CAEE3D_AdjustorThunk (RuntimeObject* __this, Func_3_tD46831209E6E19204CD8F9EAFC74DBFCA3C36C5F* ___0_compare, const RuntimeMethod* method)
{
	WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44*>(__this + _offset);
	WorkSlice_1_Sort_m9DF994BABD5BF00DE8FEB14D82F7A0A9F6CAEE3D(_thisAdjusted, ___0_compare, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 55219
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_mFEB81358558CEF0264CCE077535DB880EA2492BA_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:108>
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_0 = ___0_src;
		int32_t L_1 = ___1_srcLen;
		((  void (*) (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC*, int32_t, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(InitializedTypeInfo(method->klass)->rgctx_data, 1)))(__this, L_0, 0, L_1, il2cpp_rgctx_method(InitializedTypeInfo(method->klass)->rgctx_data, 1));
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:108>
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1__ctor_mFEB81358558CEF0264CCE077535DB880EA2492BA_AdjustorThunk (RuntimeObject* __this, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method)
{
	WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*>(__this + _offset);
	WorkSlice_1__ctor_mFEB81358558CEF0264CCE077535DB880EA2492BA(_thisAdjusted, ___0_src, ___1_srcLen, method);
}
// Method Definition Index: 55220
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_m7AC3CC7AABC83B76D23D2B94329DD4D0200156FA_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* G_B2_0 = NULL;
	WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* G_B3_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:112>
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_0 = ___0_src;
		__this->___m_Data = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_Data), (void*)L_0);
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:113>
		int32_t L_1 = ___1_srcStart;
		__this->___m_Start = L_1;
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:114>
		int32_t L_2 = ___2_srcLen;
		if ((((int32_t)L_2) < ((int32_t)0)))
		{
			G_B2_0 = __this;
			goto IL_001e;
		}
		G_B1_0 = __this;
	}
	{
		int32_t L_3 = ___2_srcLen;
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_4 = ___0_src;
		NullCheck(L_4);
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		int32_t L_5;
		L_5 = Math_Min_m53C488772A34D53917BCA2A491E79A0A5356ED52(L_3, ((int32_t)(((RuntimeArray*)L_4)->max_length)), NULL);
		G_B3_0 = L_5;
		G_B3_1 = G_B1_0;
		goto IL_0021;
	}

IL_001e:
	{
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_6 = ___0_src;
		NullCheck(L_6);
		G_B3_0 = ((int32_t)(((RuntimeArray*)L_6)->max_length));
		G_B3_1 = G_B2_0;
	}

IL_0021:
	{
		G_B3_1->___m_Length = G_B3_0;
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:116>
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1__ctor_m7AC3CC7AABC83B76D23D2B94329DD4D0200156FA_AdjustorThunk (RuntimeObject* __this, __Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method)
{
	WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*>(__this + _offset);
	WorkSlice_1__ctor_m7AC3CC7AABC83B76D23D2B94329DD4D0200156FA(_thisAdjusted, ___0_src, ___1_srcStart, ___2_srcLen, method);
}
// Method Definition Index: 55221
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_get_Item_mFDEC427E08156ECD6879AD45AEE3618B43E3F726_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, int32_t ___0_index, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_T_tA71336896536EBCB168400E4D351FEE422324E7A = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(InitializedTypeInfo(method->klass)->rgctx_data, 4));
	const Il2CppFullySharedGenericAny L_4 = alloca(SizeOf_T_tA71336896536EBCB168400E4D351FEE422324E7A);
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:120>
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_0 = __this->___m_Data;
		int32_t L_1 = __this->___m_Start;
		int32_t L_2 = ___0_index;
		NullCheck(L_0);
		int32_t L_3 = ((int32_t)il2cpp_codegen_add(L_1, L_2));
		il2cpp_codegen_memcpy(L_4, (L_0)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_3)), SizeOf_T_tA71336896536EBCB168400E4D351FEE422324E7A);
		il2cpp_codegen_memcpy(il2cppRetVal, L_4, SizeOf_T_tA71336896536EBCB168400E4D351FEE422324E7A);
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1_get_Item_mFDEC427E08156ECD6879AD45AEE3618B43E3F726_AdjustorThunk (RuntimeObject* __this, int32_t ___0_index, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*>(__this + _offset);
	WorkSlice_1_get_Item_mFDEC427E08156ECD6879AD45AEE3618B43E3F726(_thisAdjusted, ___0_index, il2cppRetVal, method);
	return;
}
// Method Definition Index: 55222
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_set_Item_m757F8BE76FAE27C149DE7C474A2B1845E08A5A0F_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, int32_t ___0_index, Il2CppFullySharedGenericAny ___1_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_T_tA71336896536EBCB168400E4D351FEE422324E7A = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(InitializedTypeInfo(method->klass)->rgctx_data, 4));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T_tA71336896536EBCB168400E4D351FEE422324E7A);
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:121>
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_0 = __this->___m_Data;
		int32_t L_1 = __this->___m_Start;
		int32_t L_2 = ___0_index;
		il2cpp_codegen_memcpy(L_3, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(InitializedTypeInfo(method->klass)->rgctx_data, 4)) ? ___1_value : &___1_value), SizeOf_T_tA71336896536EBCB168400E4D351FEE422324E7A);
		NullCheck(L_0);
		il2cpp_codegen_memcpy((L_0)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_1, L_2)))), L_3, SizeOf_T_tA71336896536EBCB168400E4D351FEE422324E7A);
		Il2CppCodeGenWriteBarrierForClass(il2cpp_rgctx_data(InitializedTypeInfo(method->klass)->rgctx_data, 4), (void**)(L_0)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_1, L_2)))), (void*)L_3);
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1_set_Item_m757F8BE76FAE27C149DE7C474A2B1845E08A5A0F_AdjustorThunk (RuntimeObject* __this, int32_t ___0_index, Il2CppFullySharedGenericAny ___1_value, const RuntimeMethod* method)
{
	WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*>(__this + _offset);
	WorkSlice_1_set_Item_m757F8BE76FAE27C149DE7C474A2B1845E08A5A0F(_thisAdjusted, ___0_index, ___1_value, method);
}
// Method Definition Index: 55223
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_length_m7212817506EACBA1AB0D914DE401C6FA05F0DD9D_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:124>
		int32_t L_0 = __this->___m_Length;
		return L_0;
	}
}
IL2CPP_EXTERN_C  int32_t WorkSlice_1_get_length_m7212817506EACBA1AB0D914DE401C6FA05F0DD9D_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = WorkSlice_1_get_length_m7212817506EACBA1AB0D914DE401C6FA05F0DD9D_inline(_thisAdjusted, method);
	return _returnValue;
}
// Method Definition Index: 55224
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_capacity_mCF0D603B7EC6E6037D0E1A14D8D0F49AD063E59E_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:125>
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_0 = __this->___m_Data;
		NullCheck(L_0);
		return ((int32_t)(((RuntimeArray*)L_0)->max_length));
	}
}
IL2CPP_EXTERN_C  int32_t WorkSlice_1_get_capacity_mCF0D603B7EC6E6037D0E1A14D8D0F49AD063E59E_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = WorkSlice_1_get_capacity_mCF0D603B7EC6E6037D0E1A14D8D0F49AD063E59E(_thisAdjusted, method);
	return _returnValue;
}
// Method Definition Index: 55225
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_Sort_mE2ED392BDF8F4F4141D7BF4C984EFE943F607A94_gshared (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, Func_3_tECED1961B53AB164A131061296ABA1276B4FBBB9* ___0_compare, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Sorting_tBB4ACAADCAA21EA710DD3998A0614ABDEF8FD8A6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:129>
		int32_t L_0 = __this->___m_Length;
		if ((((int32_t)L_0) <= ((int32_t)1)))
		{
			goto IL_002a;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:130>
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_1 = __this->___m_Data;
		int32_t L_2 = __this->___m_Start;
		int32_t L_3 = __this->___m_Start;
		int32_t L_4 = __this->___m_Length;
		Func_3_tECED1961B53AB164A131061296ABA1276B4FBBB9* L_5 = ___0_compare;
		il2cpp_codegen_runtime_class_init_inline(Sorting_tBB4ACAADCAA21EA710DD3998A0614ABDEF8FD8A6_il2cpp_TypeInfo_var);
		((  void (*) (__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC*, int32_t, int32_t, Func_3_tECED1961B53AB164A131061296ABA1276B4FBBB9*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(InitializedTypeInfo(method->klass)->rgctx_data, 6)))(L_1, L_2, ((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_3, L_4)), 1)), L_5, il2cpp_rgctx_method(InitializedTypeInfo(method->klass)->rgctx_data, 6));
	}

IL_002a:
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:131>
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1_Sort_mE2ED392BDF8F4F4141D7BF4C984EFE943F607A94_AdjustorThunk (RuntimeObject* __this, Func_3_tECED1961B53AB164A131061296ABA1276B4FBBB9* ___0_compare, const RuntimeMethod* method)
{
	WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809*>(__this + _offset);
	WorkSlice_1_Sort_mE2ED392BDF8F4F4141D7BF4C984EFE943F607A94(_thisAdjusted, ___0_compare, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 55219
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_m76CCC65E3DFB8B84A2154B65A79B56688F9B26A4_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:108>
		LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* L_0 = ___0_src;
		int32_t L_1 = ___1_srcLen;
		WorkSlice_1__ctor_mC3BCAA8301A4E37DDB26811AAFFE1A3654FA47D0(__this, L_0, 0, L_1, il2cpp_rgctx_method(InitializedTypeInfo(method->klass)->rgctx_data, 1));
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:108>
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1__ctor_m76CCC65E3DFB8B84A2154B65A79B56688F9B26A4_AdjustorThunk (RuntimeObject* __this, LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___0_src, int32_t ___1_srcLen, const RuntimeMethod* method)
{
	WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*>(__this + _offset);
	WorkSlice_1__ctor_m76CCC65E3DFB8B84A2154B65A79B56688F9B26A4(_thisAdjusted, ___0_src, ___1_srcLen, method);
}
// Method Definition Index: 55220
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1__ctor_mC3BCAA8301A4E37DDB26811AAFFE1A3654FA47D0_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* G_B2_0 = NULL;
	WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* G_B3_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:112>
		LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* L_0 = ___0_src;
		__this->___m_Data = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_Data), (void*)L_0);
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:113>
		int32_t L_1 = ___1_srcStart;
		__this->___m_Start = L_1;
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:114>
		int32_t L_2 = ___2_srcLen;
		if ((((int32_t)L_2) < ((int32_t)0)))
		{
			G_B2_0 = __this;
			goto IL_001e;
		}
		G_B1_0 = __this;
	}
	{
		int32_t L_3 = ___2_srcLen;
		LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* L_4 = ___0_src;
		NullCheck(L_4);
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		int32_t L_5;
		L_5 = Math_Min_m53C488772A34D53917BCA2A491E79A0A5356ED52(L_3, ((int32_t)(((RuntimeArray*)L_4)->max_length)), NULL);
		G_B3_0 = L_5;
		G_B3_1 = G_B1_0;
		goto IL_0021;
	}

IL_001e:
	{
		LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* L_6 = ___0_src;
		NullCheck(L_6);
		G_B3_0 = ((int32_t)(((RuntimeArray*)L_6)->max_length));
		G_B3_1 = G_B2_0;
	}

IL_0021:
	{
		G_B3_1->___m_Length = G_B3_0;
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:116>
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1__ctor_mC3BCAA8301A4E37DDB26811AAFFE1A3654FA47D0_AdjustorThunk (RuntimeObject* __this, LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* ___0_src, int32_t ___1_srcStart, int32_t ___2_srcLen, const RuntimeMethod* method)
{
	WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*>(__this + _offset);
	WorkSlice_1__ctor_mC3BCAA8301A4E37DDB26811AAFFE1A3654FA47D0(_thisAdjusted, ___0_src, ___1_srcStart, ___2_srcLen, method);
}
// Method Definition Index: 55221
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 WorkSlice_1_get_Item_mFD8EE50B88077F3EF9BCEF97BD6D0352D2E8445D_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:120>
		LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* L_0 = __this->___m_Data;
		int32_t L_1 = __this->___m_Start;
		int32_t L_2 = ___0_index;
		NullCheck(L_0);
		int32_t L_3 = ((int32_t)il2cpp_codegen_add(L_1, L_2));
		LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 L_4 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		return L_4;
	}
}
IL2CPP_EXTERN_C  LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 WorkSlice_1_get_Item_mFD8EE50B88077F3EF9BCEF97BD6D0352D2E8445D_AdjustorThunk (RuntimeObject* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*>(__this + _offset);
	LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 _returnValue;
	_returnValue = WorkSlice_1_get_Item_mFD8EE50B88077F3EF9BCEF97BD6D0352D2E8445D(_thisAdjusted, ___0_index, method);
	return _returnValue;
}
// Method Definition Index: 55222
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_set_Item_m070889CA2F62E82384BAB3CEF6D6E9AABF153663_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, int32_t ___0_index, LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 ___1_value, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:121>
		LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* L_0 = __this->___m_Data;
		int32_t L_1 = __this->___m_Start;
		int32_t L_2 = ___0_index;
		LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 L_3 = ___1_value;
		NullCheck(L_0);
		(L_0)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_1, L_2))), (LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2)L_3);
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1_set_Item_m070889CA2F62E82384BAB3CEF6D6E9AABF153663_AdjustorThunk (RuntimeObject* __this, int32_t ___0_index, LightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2 ___1_value, const RuntimeMethod* method)
{
	WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*>(__this + _offset);
	WorkSlice_1_set_Item_m070889CA2F62E82384BAB3CEF6D6E9AABF153663(_thisAdjusted, ___0_index, ___1_value, method);
}
// Method Definition Index: 55223
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_length_m0E5769CB5B052657E7327DCAD0F2CA104327D7D8_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:124>
		int32_t L_0 = __this->___m_Length;
		return L_0;
	}
}
IL2CPP_EXTERN_C  int32_t WorkSlice_1_get_length_m0E5769CB5B052657E7327DCAD0F2CA104327D7D8_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = WorkSlice_1_get_length_m0E5769CB5B052657E7327DCAD0F2CA104327D7D8_inline(_thisAdjusted, method);
	return _returnValue;
}
// Method Definition Index: 55224
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_capacity_m98A237D126494A11FF3C61211B36A790E4E8A3B0_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:125>
		LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* L_0 = __this->___m_Data;
		NullCheck(L_0);
		return ((int32_t)(((RuntimeArray*)L_0)->max_length));
	}
}
IL2CPP_EXTERN_C  int32_t WorkSlice_1_get_capacity_m98A237D126494A11FF3C61211B36A790E4E8A3B0_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = WorkSlice_1_get_capacity_m98A237D126494A11FF3C61211B36A790E4E8A3B0(_thisAdjusted, method);
	return _returnValue;
}
// Method Definition Index: 55225
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkSlice_1_Sort_m7EF532E936D55845DAAC606C0A214FE48EBF8584_gshared (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821* ___0_compare, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Sorting_tBB4ACAADCAA21EA710DD3998A0614ABDEF8FD8A6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:129>
		int32_t L_0 = __this->___m_Length;
		if ((((int32_t)L_0) <= ((int32_t)1)))
		{
			goto IL_002a;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:130>
		LightCookieMappingU5BU5D_tE1F10A7D54920D3636F1DB7774B3D5F5B560E263* L_1 = __this->___m_Data;
		int32_t L_2 = __this->___m_Start;
		int32_t L_3 = __this->___m_Start;
		int32_t L_4 = __this->___m_Length;
		Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821* L_5 = ___0_compare;
		il2cpp_codegen_runtime_class_init_inline(Sorting_tBB4ACAADCAA21EA710DD3998A0614ABDEF8FD8A6_il2cpp_TypeInfo_var);
		Sorting_QuickSort_TisLightCookieMapping_t76B317D9FDE96056FA698B46B45D7F0937BD02D2_mD7019ED48D20810C1169430283118F96945E9450(L_1, L_2, ((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_3, L_4)), 1)), L_5, il2cpp_rgctx_method(InitializedTypeInfo(method->klass)->rgctx_data, 6));
	}

IL_002a:
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:131>
		return;
	}
}
IL2CPP_EXTERN_C  void WorkSlice_1_Sort_m7EF532E936D55845DAAC606C0A214FE48EBF8584_AdjustorThunk (RuntimeObject* __this, Func_3_t3E644C82345CE04737DA5CDE018481FE0A88F821* ___0_compare, const RuntimeMethod* method)
{
	WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87*>(__this + _offset);
	WorkSlice_1_Sort_m7EF532E936D55845DAAC606C0A214FE48EBF8584(_thisAdjusted, ___0_compare, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void WriteDelegate_Invoke_mE86A5384298CF3DF2344D386DC4CA589E42DE399_Multicast(WriteDelegate_t6A0EB21668C92D873ACB875924DE54518D8B7234* __this, Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		WriteDelegate_t6A0EB21668C92D873ACB875924DE54518D8B7234* currentDelegate = reinterpret_cast<WriteDelegate_t6A0EB21668C92D873ACB875924DE54518D8B7234*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D*, float, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void WriteDelegate_Invoke_mE86A5384298CF3DF2344D386DC4CA589E42DE399_OpenInst(WriteDelegate_t6A0EB21668C92D873ACB875924DE54518D8B7234* __this, Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
void WriteDelegate_Invoke_mE86A5384298CF3DF2344D386DC4CA589E42DE399_OpenStatic(WriteDelegate_t6A0EB21668C92D873ACB875924DE54518D8B7234* __this, Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
// Method Definition Index: 13635
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate__ctor_m630834333CB7AE51AB01F7713157EE57991D03D7_gshared (WriteDelegate_t6A0EB21668C92D873ACB875924DE54518D8B7234* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_mE86A5384298CF3DF2344D386DC4CA589E42DE399_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_mE86A5384298CF3DF2344D386DC4CA589E42DE399_OpenInst;
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = __this->___method_ptr;
			__this->___method_code = (intptr_t)__this->___m_target;
		}
	}
	__this->___extra_arg = (intptr_t)&WriteDelegate_Invoke_mE86A5384298CF3DF2344D386DC4CA589E42DE399_Multicast;
}
// Method Definition Index: 13636
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate_Invoke_mE86A5384298CF3DF2344D386DC4CA589E42DE399_gshared (WriteDelegate_t6A0EB21668C92D873ACB875924DE54518D8B7234* __this, Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D* ___0_val, float ___1_fieldValue, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void WriteDelegate_Invoke_m86BA7048E52732500448764B50B058BBB1AB029A_Multicast(WriteDelegate_t737D0DA8D96562AD76BB67D9C5A5199EDB0171E1* __this, RectInt_t1744D10E1063135DA9D574F95205B98DAC600CB8* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		WriteDelegate_t737D0DA8D96562AD76BB67D9C5A5199EDB0171E1* currentDelegate = reinterpret_cast<WriteDelegate_t737D0DA8D96562AD76BB67D9C5A5199EDB0171E1*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, RectInt_t1744D10E1063135DA9D574F95205B98DAC600CB8*, int32_t, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void WriteDelegate_Invoke_m86BA7048E52732500448764B50B058BBB1AB029A_OpenInst(WriteDelegate_t737D0DA8D96562AD76BB67D9C5A5199EDB0171E1* __this, RectInt_t1744D10E1063135DA9D574F95205B98DAC600CB8* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (RectInt_t1744D10E1063135DA9D574F95205B98DAC600CB8*, int32_t, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
void WriteDelegate_Invoke_m86BA7048E52732500448764B50B058BBB1AB029A_OpenStatic(WriteDelegate_t737D0DA8D96562AD76BB67D9C5A5199EDB0171E1* __this, RectInt_t1744D10E1063135DA9D574F95205B98DAC600CB8* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (RectInt_t1744D10E1063135DA9D574F95205B98DAC600CB8*, int32_t, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
// Method Definition Index: 13635
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate__ctor_m2AA9BE88F67A2DA68720D6B5F2AFFA89E23BB597_gshared (WriteDelegate_t737D0DA8D96562AD76BB67D9C5A5199EDB0171E1* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m86BA7048E52732500448764B50B058BBB1AB029A_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m86BA7048E52732500448764B50B058BBB1AB029A_OpenInst;
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = __this->___method_ptr;
			__this->___method_code = (intptr_t)__this->___m_target;
		}
	}
	__this->___extra_arg = (intptr_t)&WriteDelegate_Invoke_m86BA7048E52732500448764B50B058BBB1AB029A_Multicast;
}
// Method Definition Index: 13636
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate_Invoke_m86BA7048E52732500448764B50B058BBB1AB029A_gshared (WriteDelegate_t737D0DA8D96562AD76BB67D9C5A5199EDB0171E1* __this, RectInt_t1744D10E1063135DA9D574F95205B98DAC600CB8* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RectInt_t1744D10E1063135DA9D574F95205B98DAC600CB8*, int32_t, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void WriteDelegate_Invoke_m6DAF352FCBE9E4A508A3AB7056209E9DEDCE6ACC_Multicast(WriteDelegate_t907C2DAF3A619B832C6D9441AF1C4CDA7914AF1D* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		WriteDelegate_t907C2DAF3A619B832C6D9441AF1C4CDA7914AF1D* currentDelegate = reinterpret_cast<WriteDelegate_t907C2DAF3A619B832C6D9441AF1C4CDA7914AF1D*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7*, float, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void WriteDelegate_Invoke_m6DAF352FCBE9E4A508A3AB7056209E9DEDCE6ACC_OpenInst(WriteDelegate_t907C2DAF3A619B832C6D9441AF1C4CDA7914AF1D* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
void WriteDelegate_Invoke_m6DAF352FCBE9E4A508A3AB7056209E9DEDCE6ACC_OpenStatic(WriteDelegate_t907C2DAF3A619B832C6D9441AF1C4CDA7914AF1D* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
// Method Definition Index: 13635
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate__ctor_m4F33ED7C62B9E61B33CC81A7B5C739D0396BC209_gshared (WriteDelegate_t907C2DAF3A619B832C6D9441AF1C4CDA7914AF1D* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m6DAF352FCBE9E4A508A3AB7056209E9DEDCE6ACC_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m6DAF352FCBE9E4A508A3AB7056209E9DEDCE6ACC_OpenInst;
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = __this->___method_ptr;
			__this->___method_code = (intptr_t)__this->___m_target;
		}
	}
	__this->___extra_arg = (intptr_t)&WriteDelegate_Invoke_m6DAF352FCBE9E4A508A3AB7056209E9DEDCE6ACC_Multicast;
}
// Method Definition Index: 13636
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate_Invoke_m6DAF352FCBE9E4A508A3AB7056209E9DEDCE6ACC_gshared (WriteDelegate_t907C2DAF3A619B832C6D9441AF1C4CDA7914AF1D* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* ___0_val, float ___1_fieldValue, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void WriteDelegate_Invoke_mDCBB3FCC716BDB01FBB6A93055CB254FEFF466CA_Multicast(WriteDelegate_tE9F20B5E1A664D239EFDD91143B963A216AAB1C7* __this, Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		WriteDelegate_tE9F20B5E1A664D239EFDD91143B963A216AAB1C7* currentDelegate = reinterpret_cast<WriteDelegate_tE9F20B5E1A664D239EFDD91143B963A216AAB1C7*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A*, int32_t, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void WriteDelegate_Invoke_mDCBB3FCC716BDB01FBB6A93055CB254FEFF466CA_OpenInst(WriteDelegate_tE9F20B5E1A664D239EFDD91143B963A216AAB1C7* __this, Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A*, int32_t, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
void WriteDelegate_Invoke_mDCBB3FCC716BDB01FBB6A93055CB254FEFF466CA_OpenStatic(WriteDelegate_tE9F20B5E1A664D239EFDD91143B963A216AAB1C7* __this, Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A*, int32_t, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
// Method Definition Index: 13635
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate__ctor_m1067E857FEE330354C23F3DB8C7B30143BCA679D_gshared (WriteDelegate_tE9F20B5E1A664D239EFDD91143B963A216AAB1C7* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_mDCBB3FCC716BDB01FBB6A93055CB254FEFF466CA_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_mDCBB3FCC716BDB01FBB6A93055CB254FEFF466CA_OpenInst;
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = __this->___method_ptr;
			__this->___method_code = (intptr_t)__this->___m_target;
		}
	}
	__this->___extra_arg = (intptr_t)&WriteDelegate_Invoke_mDCBB3FCC716BDB01FBB6A93055CB254FEFF466CA_Multicast;
}
// Method Definition Index: 13636
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate_Invoke_mDCBB3FCC716BDB01FBB6A93055CB254FEFF466CA_gshared (WriteDelegate_tE9F20B5E1A664D239EFDD91143B963A216AAB1C7* __this, Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Vector2Int_t69B2886EBAB732D9B880565E18E7568F3DE0CE6A*, int32_t, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void WriteDelegate_Invoke_m78604525C7D756C919B71D80FE8B7C42684A0F60_Multicast(WriteDelegate_t023838BBDB83C818E9FDC98ABFA9A9396823E789* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		WriteDelegate_t023838BBDB83C818E9FDC98ABFA9A9396823E789* currentDelegate = reinterpret_cast<WriteDelegate_t023838BBDB83C818E9FDC98ABFA9A9396823E789*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*, float, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void WriteDelegate_Invoke_m78604525C7D756C919B71D80FE8B7C42684A0F60_OpenInst(WriteDelegate_t023838BBDB83C818E9FDC98ABFA9A9396823E789* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
void WriteDelegate_Invoke_m78604525C7D756C919B71D80FE8B7C42684A0F60_OpenStatic(WriteDelegate_t023838BBDB83C818E9FDC98ABFA9A9396823E789* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
// Method Definition Index: 13635
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate__ctor_mC9073752A9F993A89037EB0FCF8968BCB14AE3A3_gshared (WriteDelegate_t023838BBDB83C818E9FDC98ABFA9A9396823E789* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m78604525C7D756C919B71D80FE8B7C42684A0F60_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m78604525C7D756C919B71D80FE8B7C42684A0F60_OpenInst;
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = __this->___method_ptr;
			__this->___method_code = (intptr_t)__this->___m_target;
		}
	}
	__this->___extra_arg = (intptr_t)&WriteDelegate_Invoke_m78604525C7D756C919B71D80FE8B7C42684A0F60_Multicast;
}
// Method Definition Index: 13636
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate_Invoke_m78604525C7D756C919B71D80FE8B7C42684A0F60_gshared (WriteDelegate_t023838BBDB83C818E9FDC98ABFA9A9396823E789* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* ___0_val, float ___1_fieldValue, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void WriteDelegate_Invoke_m86B402A7CEAB3ADDAB046D1975023F53BFB4E878_Multicast(WriteDelegate_t98EF2EAAD5827503FF2F0213C32A4961968D75A0* __this, Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		WriteDelegate_t98EF2EAAD5827503FF2F0213C32A4961968D75A0* currentDelegate = reinterpret_cast<WriteDelegate_t98EF2EAAD5827503FF2F0213C32A4961968D75A0*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376*, int32_t, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void WriteDelegate_Invoke_m86B402A7CEAB3ADDAB046D1975023F53BFB4E878_OpenInst(WriteDelegate_t98EF2EAAD5827503FF2F0213C32A4961968D75A0* __this, Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376*, int32_t, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
void WriteDelegate_Invoke_m86B402A7CEAB3ADDAB046D1975023F53BFB4E878_OpenStatic(WriteDelegate_t98EF2EAAD5827503FF2F0213C32A4961968D75A0* __this, Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376*, int32_t, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
// Method Definition Index: 13635
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate__ctor_mAA1CB4066F7346F24DA38ED5A1240309F0C4BC60_gshared (WriteDelegate_t98EF2EAAD5827503FF2F0213C32A4961968D75A0* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m86B402A7CEAB3ADDAB046D1975023F53BFB4E878_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m86B402A7CEAB3ADDAB046D1975023F53BFB4E878_OpenInst;
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = __this->___method_ptr;
			__this->___method_code = (intptr_t)__this->___m_target;
		}
	}
	__this->___extra_arg = (intptr_t)&WriteDelegate_Invoke_m86B402A7CEAB3ADDAB046D1975023F53BFB4E878_Multicast;
}
// Method Definition Index: 13636
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate_Invoke_m86B402A7CEAB3ADDAB046D1975023F53BFB4E878_gshared (WriteDelegate_t98EF2EAAD5827503FF2F0213C32A4961968D75A0* __this, Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376* ___0_val, int32_t ___1_fieldValue, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Vector3Int_t65CB06F557251D18A37BD71F3655BA836A357376*, int32_t, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void WriteDelegate_Invoke_mCB317932D29E39DF2768AD06B5DA7A84CD3A2C16_Multicast(WriteDelegate_t055D02BADD3A5DFA009116D80BC93C235313CAE8* __this, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		WriteDelegate_t055D02BADD3A5DFA009116D80BC93C235313CAE8* currentDelegate = reinterpret_cast<WriteDelegate_t055D02BADD3A5DFA009116D80BC93C235313CAE8*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3*, float, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void WriteDelegate_Invoke_mCB317932D29E39DF2768AD06B5DA7A84CD3A2C16_OpenInst(WriteDelegate_t055D02BADD3A5DFA009116D80BC93C235313CAE8* __this, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
void WriteDelegate_Invoke_mCB317932D29E39DF2768AD06B5DA7A84CD3A2C16_OpenStatic(WriteDelegate_t055D02BADD3A5DFA009116D80BC93C235313CAE8* __this, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* ___0_val, float ___1_fieldValue, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr)(___0_val, ___1_fieldValue, method);
}
// Method Definition Index: 13635
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate__ctor_m6165AFE856EC0CC9CDE8A145B404312481261696_gshared (WriteDelegate_t055D02BADD3A5DFA009116D80BC93C235313CAE8* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_mCB317932D29E39DF2768AD06B5DA7A84CD3A2C16_OpenStatic;
		else
			{
				__this->___invoke_impl = __this->___method_ptr;
				__this->___method_code = (intptr_t)__this->___m_target;
			}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_mCB317932D29E39DF2768AD06B5DA7A84CD3A2C16_OpenInst;
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = __this->___method_ptr;
			__this->___method_code = (intptr_t)__this->___m_target;
		}
	}
	__this->___extra_arg = (intptr_t)&WriteDelegate_Invoke_mCB317932D29E39DF2768AD06B5DA7A84CD3A2C16_Multicast;
}
// Method Definition Index: 13636
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate_Invoke_mCB317932D29E39DF2768AD06B5DA7A84CD3A2C16_gshared (WriteDelegate_t055D02BADD3A5DFA009116D80BC93C235313CAE8* __this, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3* ___0_val, float ___1_fieldValue, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3*, float, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_Multicast(WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7* __this, Il2CppFullySharedGenericAny* ___0_val, Il2CppFullySharedGenericAny ___1_fieldValue, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7* currentDelegate = reinterpret_cast<WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny*, Il2CppFullySharedGenericAny, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_OpenStaticInvoker(WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7* __this, Il2CppFullySharedGenericAny* ___0_val, Il2CppFullySharedGenericAny ___1_fieldValue, const RuntimeMethod* method)
{
	InvokerActionInvoker2< Il2CppFullySharedGenericAny*, Il2CppFullySharedGenericAny >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_val, ___1_fieldValue);
}
void WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_ClosedStaticInvoker(WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7* __this, Il2CppFullySharedGenericAny* ___0_val, Il2CppFullySharedGenericAny ___1_fieldValue, const RuntimeMethod* method)
{
	InvokerActionInvoker3< RuntimeObject*, Il2CppFullySharedGenericAny*, Il2CppFullySharedGenericAny >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_val, ___1_fieldValue);
}
void WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_ClosedInstInvoker(WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7* __this, Il2CppFullySharedGenericAny* ___0_val, Il2CppFullySharedGenericAny ___1_fieldValue, const RuntimeMethod* method)
{
	InvokerActionInvoker2< Il2CppFullySharedGenericAny*, Il2CppFullySharedGenericAny >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_val, ___1_fieldValue);
}
void WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_OpenInstInvoker(WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7* __this, Il2CppFullySharedGenericAny* ___0_val, Il2CppFullySharedGenericAny ___1_fieldValue, const RuntimeMethod* method)
{
	NullCheck(___0_val);
	InvokerActionInvoker1< Il2CppFullySharedGenericAny >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_val, ___1_fieldValue);
}
// Method Definition Index: 13635
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate__ctor_mCE6F306923A685DD2E41E1BAABB666E0F7B4E137_gshared (WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_OpenInstInvoker;
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_Multicast;
}
// Method Definition Index: 13636
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteDelegate_Invoke_m314AB1F8889F277917B21F5F09093D797490FE93_gshared (WriteDelegate_tCC7EDE8329D3D4B81ABF643CABCC600B2CC335D7* __this, Il2CppFullySharedGenericAny* ___0_val, Il2CppFullySharedGenericAny ___1_fieldValue, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny*, Il2CppFullySharedGenericAny, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_val, ___1_fieldValue, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 115031
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XHashtableState__ctor_m37E975C296D7D8CDF9ACAA9ABD7C4A0C82C427D3_gshared (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* ___0_extractKey, int32_t ___1_capacity, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2((RuntimeObject*)__this, NULL);
		int32_t L_0 = ___1_capacity;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)L_0);
		__this->____buckets = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____buckets), (void*)L_1);
		int32_t L_2 = ___1_capacity;
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_3 = (EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635*)(EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635*)SZArrayNew(il2cpp_rgctx_data(method->klass->rgctx_data, 1), (uint32_t)L_2);
		__this->____entries = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____entries), (void*)L_3);
		ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* L_4 = ___0_extractKey;
		__this->____extractKey = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____extractKey), (void*)L_4);
		return;
	}
}
// Method Definition Index: 115032
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* XHashtableState_Resize_mDB3BA5C327EF6A86F6CE58B59E1D7430E62532C5_gshared (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	RuntimeObject* V_6 = NULL;
	{
		int32_t L_0 = __this->____numEntries;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = __this->____buckets;
		NullCheck(L_1);
		if ((((int32_t)L_0) >= ((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length)))))
		{
			goto IL_0012;
		}
	}
	{
		return __this;
	}

IL_0012:
	{
		V_0 = 0;
		V_2 = 0;
		goto IL_00a7;
	}

IL_001b:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_2 = __this->____buckets;
		int32_t L_3 = V_2;
		NullCheck(L_2);
		int32_t L_4 = L_3;
		int32_t L_5 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		V_3 = L_5;
		int32_t L_6 = V_3;
		if (L_6)
		{
			goto IL_009f;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_7 = __this->____buckets;
		int32_t L_8 = V_2;
		NullCheck(L_7);
		int32_t L_9;
		L_9 = Interlocked_CompareExchange_mB06E8737D3DA41F9FFBC38A6D0583D515EFB5717(((L_7)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_8))), (-1), 0, NULL);
		V_3 = L_9;
		goto IL_009f;
	}

IL_003d:
	{
		ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* L_10 = __this->____extractKey;
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_11 = __this->____entries;
		int32_t L_12 = V_3;
		NullCheck(L_11);
		RuntimeObject* L_13 = ((L_11)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_12)))->___Value;
		NullCheck(L_10);
		String_t* L_14;
		L_14 = ExtractKeyDelegate_Invoke_m3214A3F92C2EB22088AB7738E8DFE1BE70925148_inline(L_10, L_13, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		if (!L_14)
		{
			goto IL_005f;
		}
	}
	{
		int32_t L_15 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_15, 1));
	}

IL_005f:
	{
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_16 = __this->____entries;
		int32_t L_17 = V_3;
		NullCheck(L_16);
		int32_t L_18 = ((L_16)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_17)))->___Next;
		if (L_18)
		{
			goto IL_008d;
		}
	}
	{
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_19 = __this->____entries;
		int32_t L_20 = V_3;
		NullCheck(L_19);
		int32_t* L_21 = (int32_t*)(&((L_19)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_20)))->___Next);
		int32_t L_22;
		L_22 = Interlocked_CompareExchange_mB06E8737D3DA41F9FFBC38A6D0583D515EFB5717(L_21, (-1), 0, NULL);
		V_3 = L_22;
		goto IL_009f;
	}

IL_008d:
	{
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_23 = __this->____entries;
		int32_t L_24 = V_3;
		NullCheck(L_23);
		int32_t L_25 = ((L_23)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_24)))->___Next;
		V_3 = L_25;
	}

IL_009f:
	{
		int32_t L_26 = V_3;
		if ((((int32_t)L_26) > ((int32_t)0)))
		{
			goto IL_003d;
		}
	}
	{
		int32_t L_27 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_27, 1));
	}

IL_00a7:
	{
		int32_t L_28 = V_2;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_29 = __this->____buckets;
		NullCheck(L_29);
		if ((((int32_t)L_28) < ((int32_t)((int32_t)(((RuntimeArray*)L_29)->max_length)))))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_30 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_31 = __this->____buckets;
		NullCheck(L_31);
		if ((((int32_t)L_30) >= ((int32_t)((int32_t)(((int32_t)(((RuntimeArray*)L_31)->max_length))/2)))))
		{
			goto IL_00cd;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_32 = __this->____buckets;
		NullCheck(L_32);
		V_0 = ((int32_t)(((RuntimeArray*)L_32)->max_length));
		goto IL_00e2;
	}

IL_00cd:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_33 = __this->____buckets;
		NullCheck(L_33);
		V_0 = ((int32_t)il2cpp_codegen_multiply(((int32_t)(((RuntimeArray*)L_33)->max_length)), 2));
		int32_t L_34 = V_0;
		if ((((int32_t)L_34) >= ((int32_t)0)))
		{
			goto IL_00e2;
		}
	}
	{
		OverflowException_t6F6AD8CACE20C37F701C05B373A215C4802FAB0C* L_35 = (OverflowException_t6F6AD8CACE20C37F701C05B373A215C4802FAB0C*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&OverflowException_t6F6AD8CACE20C37F701C05B373A215C4802FAB0C_il2cpp_TypeInfo_var)));
		OverflowException__ctor_m7F6A928C9BE47384586BDDE8B4B87666421E0F1A(L_35, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_35, method);
	}

IL_00e2:
	{
		ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* L_36 = __this->____extractKey;
		int32_t L_37 = V_0;
		XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* L_38 = (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 0));
		XHashtableState__ctor_m37E975C296D7D8CDF9ACAA9ABD7C4A0C82C427D3(L_38, L_36, L_37, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		V_1 = L_38;
		V_4 = 0;
		goto IL_013b;
	}

IL_00f4:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_39 = __this->____buckets;
		int32_t L_40 = V_4;
		NullCheck(L_39);
		int32_t L_41 = L_40;
		int32_t L_42 = (L_39)->GetAt(static_cast<il2cpp_array_size_t>(L_41));
		V_5 = L_42;
		goto IL_0130;
	}

IL_0101:
	{
		XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* L_43 = V_1;
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_44 = __this->____entries;
		int32_t L_45 = V_5;
		NullCheck(L_44);
		RuntimeObject* L_46 = ((L_44)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_45)))->___Value;
		NullCheck(L_43);
		bool L_47;
		L_47 = XHashtableState_TryAdd_m951A9A914307495745E2B33DB0BA6583FB4060A1(L_43, L_46, (&V_6), il2cpp_rgctx_method(method->klass->rgctx_data, 8));
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_48 = __this->____entries;
		int32_t L_49 = V_5;
		NullCheck(L_48);
		int32_t L_50 = ((L_48)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_49)))->___Next;
		V_5 = L_50;
	}

IL_0130:
	{
		int32_t L_51 = V_5;
		if ((((int32_t)L_51) > ((int32_t)0)))
		{
			goto IL_0101;
		}
	}
	{
		int32_t L_52 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_52, 1));
	}

IL_013b:
	{
		int32_t L_53 = V_4;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_54 = __this->____buckets;
		NullCheck(L_54);
		if ((((int32_t)L_53) < ((int32_t)((int32_t)(((RuntimeArray*)L_54)->max_length)))))
		{
			goto IL_00f4;
		}
	}
	{
		XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* L_55 = V_1;
		return L_55;
	}
}
// Method Definition Index: 115033
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtableState_TryGetValue_m22BFB31B1A4E2CEDE4CA7133F4A0B50B9E514308_gshared (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, String_t* ___0_key, int32_t ___1_index, int32_t ___2_count, RuntimeObject** ___3_value, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		String_t* L_0 = ___0_key;
		int32_t L_1 = ___1_index;
		int32_t L_2 = ___2_count;
		int32_t L_3;
		L_3 = XHashtableState_ComputeHashCode_mD58A823B4A09F8DB93853EA9536E6B457B59F1B1(L_0, L_1, L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		V_0 = L_3;
		V_1 = 0;
		int32_t L_4 = V_0;
		String_t* L_5 = ___0_key;
		int32_t L_6 = ___1_index;
		int32_t L_7 = ___2_count;
		bool L_8;
		L_8 = XHashtableState_FindEntry_m3AC0430564190D3FCAD9A8DB1DD0E725F7392A91(__this, L_4, L_5, L_6, L_7, (&V_1), il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		if (!L_8)
		{
			goto IL_0033;
		}
	}
	{
		RuntimeObject** L_9 = ___3_value;
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_10 = __this->____entries;
		int32_t L_11 = V_1;
		NullCheck(L_10);
		RuntimeObject* L_12 = ((L_10)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_11)))->___Value;
		*(RuntimeObject**)L_9 = L_12;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_9, (void*)L_12);
		return (bool)1;
	}

IL_0033:
	{
		RuntimeObject** L_13 = ___3_value;
		il2cpp_codegen_initobj(L_13, sizeof(RuntimeObject*));
		return (bool)0;
	}
}
// Method Definition Index: 115034
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtableState_TryAdd_m951A9A914307495745E2B33DB0BA6583FB4060A1_gshared (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, RuntimeObject* ___0_value, RuntimeObject** ___1_newValue, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	String_t* V_2 = NULL;
	int32_t V_3 = 0;
	{
		RuntimeObject** L_0 = ___1_newValue;
		RuntimeObject* L_1 = ___0_value;
		*(RuntimeObject**)L_0 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_0, (void*)L_1);
		ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* L_2 = __this->____extractKey;
		RuntimeObject* L_3 = ___0_value;
		NullCheck(L_2);
		String_t* L_4;
		L_4 = ExtractKeyDelegate_Invoke_m3214A3F92C2EB22088AB7738E8DFE1BE70925148_inline(L_2, L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		V_2 = L_4;
		String_t* L_5 = V_2;
		if (L_5)
		{
			goto IL_0019;
		}
	}
	{
		return (bool)1;
	}

IL_0019:
	{
		String_t* L_6 = V_2;
		String_t* L_7 = V_2;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_7, NULL);
		int32_t L_9;
		L_9 = XHashtableState_ComputeHashCode_mD58A823B4A09F8DB93853EA9536E6B457B59F1B1(L_6, 0, L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		V_3 = L_9;
		int32_t* L_10 = (int32_t*)(&__this->____numEntries);
		int32_t L_11;
		L_11 = Interlocked_Increment_m3C240C32E8D9544EC050B74D4F28EEB58F1F9309(L_10, NULL);
		V_0 = L_11;
		int32_t L_12 = V_0;
		if ((((int32_t)L_12) < ((int32_t)0)))
		{
			goto IL_0042;
		}
	}
	{
		int32_t L_13 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_14 = __this->____buckets;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0044;
		}
	}

IL_0042:
	{
		return (bool)0;
	}

IL_0044:
	{
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_15 = __this->____entries;
		int32_t L_16 = V_0;
		NullCheck(L_15);
		RuntimeObject* L_17 = ___0_value;
		((L_15)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_16)))->___Value = L_17;
		Il2CppCodeGenWriteBarrier((void**)(&((L_15)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_16)))->___Value), (void*)L_17);
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_18 = __this->____entries;
		int32_t L_19 = V_0;
		NullCheck(L_18);
		int32_t L_20 = V_3;
		((L_18)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_19)))->___HashCode = L_20;
		Thread_MemoryBarrier_m83873F1E6CEB16C0781941141382DA874A36097D(NULL);
		V_1 = 0;
		goto IL_00b7;
	}

IL_0071:
	{
		int32_t L_21 = V_1;
		if (L_21)
		{
			goto IL_0095;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_22 = __this->____buckets;
		int32_t L_23 = V_3;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_24 = __this->____buckets;
		NullCheck(L_24);
		NullCheck(L_22);
		int32_t L_25 = V_0;
		int32_t L_26;
		L_26 = Interlocked_CompareExchange_mB06E8737D3DA41F9FFBC38A6D0583D515EFB5717(((L_22)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)(L_23&((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_24)->max_length)), 1))))))), L_25, 0, NULL);
		V_1 = L_26;
		goto IL_00ae;
	}

IL_0095:
	{
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_27 = __this->____entries;
		int32_t L_28 = V_1;
		NullCheck(L_27);
		int32_t* L_29 = (int32_t*)(&((L_27)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_28)))->___Next);
		int32_t L_30 = V_0;
		int32_t L_31;
		L_31 = Interlocked_CompareExchange_mB06E8737D3DA41F9FFBC38A6D0583D515EFB5717(L_29, L_30, 0, NULL);
		V_1 = L_31;
	}

IL_00ae:
	{
		int32_t L_32 = V_1;
		if ((((int32_t)L_32) > ((int32_t)0)))
		{
			goto IL_00b7;
		}
	}
	{
		int32_t L_33 = V_1;
		return (bool)((((int32_t)L_33) == ((int32_t)0))? 1 : 0);
	}

IL_00b7:
	{
		int32_t L_34 = V_3;
		String_t* L_35 = V_2;
		String_t* L_36 = V_2;
		NullCheck(L_36);
		int32_t L_37;
		L_37 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_36, NULL);
		bool L_38;
		L_38 = XHashtableState_FindEntry_m3AC0430564190D3FCAD9A8DB1DD0E725F7392A91(__this, L_34, L_35, 0, L_37, (&V_1), il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		if (!L_38)
		{
			goto IL_0071;
		}
	}
	{
		RuntimeObject** L_39 = ___1_newValue;
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_40 = __this->____entries;
		int32_t L_41 = V_1;
		NullCheck(L_40);
		RuntimeObject* L_42 = ((L_40)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_41)))->___Value;
		*(RuntimeObject**)L_39 = L_42;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_39, (void*)L_42);
		return (bool)1;
	}
}
// Method Definition Index: 115035
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtableState_FindEntry_m3AC0430564190D3FCAD9A8DB1DD0E725F7392A91_gshared (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* __this, int32_t ___0_hashCode, String_t* ___1_key, int32_t ___2_index, int32_t ___3_count, int32_t* ___4_entryIndex, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	String_t* V_2 = NULL;
	{
		int32_t* L_0 = ___4_entryIndex;
		int32_t L_1 = *((int32_t*)L_0);
		V_0 = L_1;
		int32_t L_2 = V_0;
		if (L_2)
		{
			goto IL_0020;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_3 = __this->____buckets;
		int32_t L_4 = ___0_hashCode;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_5 = __this->____buckets;
		NullCheck(L_5);
		NullCheck(L_3);
		int32_t L_6 = ((int32_t)(L_4&((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_5)->max_length)), 1))));
		int32_t L_7 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_1 = L_7;
		goto IL_00f9;
	}

IL_0020:
	{
		int32_t L_8 = V_0;
		V_1 = L_8;
		goto IL_00f9;
	}

IL_0027:
	{
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_9 = __this->____entries;
		int32_t L_10 = V_1;
		NullCheck(L_9);
		int32_t L_11 = ((L_9)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_10)))->___HashCode;
		int32_t L_12 = ___0_hashCode;
		if ((!(((uint32_t)L_11) == ((uint32_t)L_12))))
		{
			goto IL_00e5;
		}
	}
	{
		ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* L_13 = __this->____extractKey;
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_14 = __this->____entries;
		int32_t L_15 = V_1;
		NullCheck(L_14);
		RuntimeObject* L_16 = ((L_14)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_15)))->___Value;
		NullCheck(L_13);
		String_t* L_17;
		L_17 = ExtractKeyDelegate_Invoke_m3214A3F92C2EB22088AB7738E8DFE1BE70925148_inline(L_13, L_16, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		V_2 = L_17;
		String_t* L_18 = V_2;
		if (L_18)
		{
			goto IL_00c8;
		}
	}
	{
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_19 = __this->____entries;
		int32_t L_20 = V_1;
		NullCheck(L_19);
		int32_t L_21 = ((L_19)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_20)))->___Next;
		if ((((int32_t)L_21) <= ((int32_t)0)))
		{
			goto IL_00e5;
		}
	}
	{
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_22 = __this->____entries;
		int32_t L_23 = V_1;
		NullCheck(L_22);
		RuntimeObject** L_24 = (RuntimeObject**)(&((L_22)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_23)))->___Value);
		il2cpp_codegen_initobj(L_24, sizeof(RuntimeObject*));
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_25 = __this->____entries;
		int32_t L_26 = V_1;
		NullCheck(L_25);
		int32_t L_27 = ((L_25)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_26)))->___Next;
		V_1 = L_27;
		int32_t L_28 = V_0;
		if (L_28)
		{
			goto IL_00b4;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_29 = __this->____buckets;
		int32_t L_30 = ___0_hashCode;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_31 = __this->____buckets;
		NullCheck(L_31);
		int32_t L_32 = V_1;
		NullCheck(L_29);
		(L_29)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)(L_30&((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_31)->max_length)), 1))))), (int32_t)L_32);
		goto IL_00f9;
	}

IL_00b4:
	{
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_33 = __this->____entries;
		int32_t L_34 = V_0;
		NullCheck(L_33);
		int32_t L_35 = V_1;
		((L_33)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_34)))->___Next = L_35;
		goto IL_00f9;
	}

IL_00c8:
	{
		int32_t L_36 = ___3_count;
		String_t* L_37 = V_2;
		NullCheck(L_37);
		int32_t L_38;
		L_38 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_37, NULL);
		if ((!(((uint32_t)L_36) == ((uint32_t)L_38))))
		{
			goto IL_00e5;
		}
	}
	{
		String_t* L_39 = ___1_key;
		int32_t L_40 = ___2_index;
		String_t* L_41 = V_2;
		int32_t L_42 = ___3_count;
		int32_t L_43;
		L_43 = String_CompareOrdinal_m8940CFAE90021ED8DA3F2DF8226941C9EEB2E32D(L_39, L_40, L_41, 0, L_42, NULL);
		if (L_43)
		{
			goto IL_00e5;
		}
	}
	{
		int32_t* L_44 = ___4_entryIndex;
		int32_t L_45 = V_1;
		*((int32_t*)L_44) = (int32_t)L_45;
		return (bool)1;
	}

IL_00e5:
	{
		int32_t L_46 = V_1;
		V_0 = L_46;
		EntryU5BU5D_tA5AD9C5E098FD22F628C31033C0DAD7AD6F59635* L_47 = __this->____entries;
		int32_t L_48 = V_1;
		NullCheck(L_47);
		int32_t L_49 = ((L_47)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_48)))->___Next;
		V_1 = L_49;
	}

IL_00f9:
	{
		int32_t L_50 = V_1;
		if ((((int32_t)L_50) > ((int32_t)0)))
		{
			goto IL_0027;
		}
	}
	{
		int32_t* L_51 = ___4_entryIndex;
		int32_t L_52 = V_0;
		*((int32_t*)L_51) = (int32_t)L_52;
		return (bool)0;
	}
}
// Method Definition Index: 115036
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t XHashtableState_ComputeHashCode_mD58A823B4A09F8DB93853EA9536E6B457B59F1B1_gshared (String_t* ___0_key, int32_t ___1_index, int32_t ___2_count, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		V_0 = ((int32_t)352654597);
		int32_t L_0 = ___1_index;
		int32_t L_1 = ___2_count;
		V_1 = ((int32_t)il2cpp_codegen_add(L_0, L_1));
		int32_t L_2 = ___1_index;
		V_2 = L_2;
		goto IL_0020;
	}

IL_000e:
	{
		int32_t L_3 = V_0;
		int32_t L_4 = V_0;
		String_t* L_5 = ___0_key;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		Il2CppChar L_7;
		L_7 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_5, L_6, NULL);
		V_0 = ((int32_t)il2cpp_codegen_add(L_3, ((int32_t)(((int32_t)(L_4<<7))^(int32_t)L_7))));
		int32_t L_8 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_0020:
	{
		int32_t L_9 = V_2;
		int32_t L_10 = V_1;
		if ((((int32_t)L_9) < ((int32_t)L_10)))
		{
			goto IL_000e;
		}
	}
	{
		int32_t L_11 = V_0;
		int32_t L_12 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_11, ((int32_t)(L_12>>((int32_t)17)))));
		int32_t L_13 = V_0;
		int32_t L_14 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_13, ((int32_t)(L_14>>((int32_t)11)))));
		int32_t L_15 = V_0;
		int32_t L_16 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_15, ((int32_t)(L_16>>5))));
		int32_t L_17 = V_0;
		return ((int32_t)(L_17&((int32_t)2147483647LL)));
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 115031
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XHashtableState__ctor_mC2ED3CAB78829509332331B146E7165C58D3DD0F_gshared (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* __this, ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD* ___0_extractKey, int32_t ___1_capacity, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2((RuntimeObject*)__this, NULL);
		int32_t L_0 = ___1_capacity;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)L_0);
		__this->____buckets = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____buckets), (void*)L_1);
		int32_t L_2 = ___1_capacity;
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_3 = (EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4*)(EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4*)SZArrayNew(il2cpp_rgctx_data(method->klass->rgctx_data, 1), (uint32_t)L_2);
		__this->____entries = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____entries), (void*)L_3);
		ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD* L_4 = ___0_extractKey;
		__this->____extractKey = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____extractKey), (void*)L_4);
		return;
	}
}
// Method Definition Index: 115032
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* XHashtableState_Resize_m3CD152F50AD9E53B808C9B1CEC069D894A621202_gshared (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* __this, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5));
	const Il2CppFullySharedGenericAny L_13 = alloca(SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
	const Il2CppFullySharedGenericAny L_45 = L_13;
	int32_t V_0 = 0;
	XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	Il2CppFullySharedGenericAny V_6 = alloca(SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
	memset(V_6, 0, SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
	{
		int32_t L_0 = __this->____numEntries;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = __this->____buckets;
		NullCheck(L_1);
		if ((((int32_t)L_0) >= ((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length)))))
		{
			goto IL_0012;
		}
	}
	{
		return __this;
	}

IL_0012:
	{
		V_0 = 0;
		V_2 = 0;
		goto IL_00a7;
	}

IL_001b:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_2 = __this->____buckets;
		int32_t L_3 = V_2;
		NullCheck(L_2);
		int32_t L_4 = L_3;
		int32_t L_5 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		V_3 = L_5;
		int32_t L_6 = V_3;
		if (L_6)
		{
			goto IL_009f;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_7 = __this->____buckets;
		int32_t L_8 = V_2;
		NullCheck(L_7);
		int32_t L_9;
		L_9 = Interlocked_CompareExchange_mB06E8737D3DA41F9FFBC38A6D0583D515EFB5717(((L_7)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_8))), (-1), 0, NULL);
		V_3 = L_9;
		goto IL_009f;
	}

IL_003d:
	{
		ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD* L_10 = __this->____extractKey;
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_11 = __this->____entries;
		int32_t L_12 = V_3;
		NullCheck(L_11);
		il2cpp_codegen_memcpy(L_13, il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_11)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_12))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),0)), SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		NullCheck(L_10);
		String_t* L_14;
		L_14 = InvokerFuncInvoker1< String_t*, Il2CppFullySharedGenericAny >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)), il2cpp_rgctx_method(method->klass->rgctx_data, 6), L_10, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5)) ? L_13: *(void**)L_13));
		if (!L_14)
		{
			goto IL_005f;
		}
	}
	{
		int32_t L_15 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_15, 1));
	}

IL_005f:
	{
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_16 = __this->____entries;
		int32_t L_17 = V_3;
		NullCheck(L_16);
		int32_t L_18 = *(int32_t*)il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_16)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_17))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),2));
		if (L_18)
		{
			goto IL_008d;
		}
	}
	{
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_19 = __this->____entries;
		int32_t L_20 = V_3;
		NullCheck(L_19);
		int32_t L_21;
		L_21 = Interlocked_CompareExchange_mB06E8737D3DA41F9FFBC38A6D0583D515EFB5717((((int32_t*)il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_19)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_20))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),2)))), (-1), 0, NULL);
		V_3 = L_21;
		goto IL_009f;
	}

IL_008d:
	{
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_22 = __this->____entries;
		int32_t L_23 = V_3;
		NullCheck(L_22);
		int32_t L_24 = *(int32_t*)il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_22)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_23))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),2));
		V_3 = L_24;
	}

IL_009f:
	{
		int32_t L_25 = V_3;
		if ((((int32_t)L_25) > ((int32_t)0)))
		{
			goto IL_003d;
		}
	}
	{
		int32_t L_26 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_26, 1));
	}

IL_00a7:
	{
		int32_t L_27 = V_2;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_28 = __this->____buckets;
		NullCheck(L_28);
		if ((((int32_t)L_27) < ((int32_t)((int32_t)(((RuntimeArray*)L_28)->max_length)))))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_29 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_30 = __this->____buckets;
		NullCheck(L_30);
		if ((((int32_t)L_29) >= ((int32_t)((int32_t)(((int32_t)(((RuntimeArray*)L_30)->max_length))/2)))))
		{
			goto IL_00cd;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_31 = __this->____buckets;
		NullCheck(L_31);
		V_0 = ((int32_t)(((RuntimeArray*)L_31)->max_length));
		goto IL_00e2;
	}

IL_00cd:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_32 = __this->____buckets;
		NullCheck(L_32);
		V_0 = ((int32_t)il2cpp_codegen_multiply(((int32_t)(((RuntimeArray*)L_32)->max_length)), 2));
		int32_t L_33 = V_0;
		if ((((int32_t)L_33) >= ((int32_t)0)))
		{
			goto IL_00e2;
		}
	}
	{
		OverflowException_t6F6AD8CACE20C37F701C05B373A215C4802FAB0C* L_34 = (OverflowException_t6F6AD8CACE20C37F701C05B373A215C4802FAB0C*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&OverflowException_t6F6AD8CACE20C37F701C05B373A215C4802FAB0C_il2cpp_TypeInfo_var)));
		OverflowException__ctor_m7F6A928C9BE47384586BDDE8B4B87666421E0F1A(L_34, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_34, method);
	}

IL_00e2:
	{
		ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD* L_35 = __this->____extractKey;
		int32_t L_36 = V_0;
		XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* L_37 = (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 0));
		((  void (*) (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D*, ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_37, L_35, L_36, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		V_1 = L_37;
		V_4 = 0;
		goto IL_013b;
	}

IL_00f4:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_38 = __this->____buckets;
		int32_t L_39 = V_4;
		NullCheck(L_38);
		int32_t L_40 = L_39;
		int32_t L_41 = (L_38)->GetAt(static_cast<il2cpp_array_size_t>(L_40));
		V_5 = L_41;
		goto IL_0130;
	}

IL_0101:
	{
		XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* L_42 = V_1;
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_43 = __this->____entries;
		int32_t L_44 = V_5;
		NullCheck(L_43);
		il2cpp_codegen_memcpy(L_45, il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_43)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_44))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),0)), SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		NullCheck(L_42);
		bool L_46;
		L_46 = InvokerFuncInvoker2< bool, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 8)), il2cpp_rgctx_method(method->klass->rgctx_data, 8), L_42, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5)) ? L_45: *(void**)L_45), (Il2CppFullySharedGenericAny*)V_6);
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_47 = __this->____entries;
		int32_t L_48 = V_5;
		NullCheck(L_47);
		int32_t L_49 = *(int32_t*)il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_47)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_48))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),2));
		V_5 = L_49;
	}

IL_0130:
	{
		int32_t L_50 = V_5;
		if ((((int32_t)L_50) > ((int32_t)0)))
		{
			goto IL_0101;
		}
	}
	{
		int32_t L_51 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_51, 1));
	}

IL_013b:
	{
		int32_t L_52 = V_4;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_53 = __this->____buckets;
		NullCheck(L_53);
		if ((((int32_t)L_52) < ((int32_t)((int32_t)(((RuntimeArray*)L_53)->max_length)))))
		{
			goto IL_00f4;
		}
	}
	{
		XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* L_54 = V_1;
		return L_54;
	}
}
// Method Definition Index: 115033
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtableState_TryGetValue_m94EE8AEAE527C34D9D2B86D03E1D04FF867266F3_gshared (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* __this, String_t* ___0_key, int32_t ___1_index, int32_t ___2_count, Il2CppFullySharedGenericAny* ___3_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5));
	const Il2CppFullySharedGenericAny L_12 = alloca(SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		String_t* L_0 = ___0_key;
		int32_t L_1 = ___1_index;
		int32_t L_2 = ___2_count;
		int32_t L_3;
		L_3 = ((  int32_t (*) (String_t*, int32_t, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))(L_0, L_1, L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		V_0 = L_3;
		V_1 = 0;
		int32_t L_4 = V_0;
		String_t* L_5 = ___0_key;
		int32_t L_6 = ___1_index;
		int32_t L_7 = ___2_count;
		bool L_8;
		L_8 = ((  bool (*) (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D*, int32_t, String_t*, int32_t, int32_t, int32_t*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))(__this, L_4, L_5, L_6, L_7, (&V_1), il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		if (!L_8)
		{
			goto IL_0033;
		}
	}
	{
		Il2CppFullySharedGenericAny* L_9 = ___3_value;
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_10 = __this->____entries;
		int32_t L_11 = V_1;
		NullCheck(L_10);
		il2cpp_codegen_memcpy(L_12, il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_10)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_11))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),0)), SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		il2cpp_codegen_memcpy((Il2CppFullySharedGenericAny*)L_9, L_12, SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		Il2CppCodeGenWriteBarrierForClass(il2cpp_rgctx_data(method->klass->rgctx_data, 5), (void**)(Il2CppFullySharedGenericAny*)L_9, (void*)L_12);
		return (bool)1;
	}

IL_0033:
	{
		Il2CppFullySharedGenericAny* L_13 = ___3_value;
		il2cpp_codegen_initobj(L_13, SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		return (bool)0;
	}
}
// Method Definition Index: 115034
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtableState_TryAdd_m25BEF4B433B3B23CE79C25AA27DA2FFB624CCAE2_gshared (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* __this, Il2CppFullySharedGenericAny ___0_value, Il2CppFullySharedGenericAny* ___1_newValue, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
	const Il2CppFullySharedGenericAny L_17 = L_1;
	const Il2CppFullySharedGenericAny L_41 = L_1;
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	String_t* V_2 = NULL;
	int32_t V_3 = 0;
	{
		Il2CppFullySharedGenericAny* L_0 = ___1_newValue;
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5)) ? ___0_value : &___0_value), SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		il2cpp_codegen_memcpy((Il2CppFullySharedGenericAny*)L_0, L_1, SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		Il2CppCodeGenWriteBarrierForClass(il2cpp_rgctx_data(method->klass->rgctx_data, 5), (void**)(Il2CppFullySharedGenericAny*)L_0, (void*)L_1);
		ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD* L_2 = __this->____extractKey;
		il2cpp_codegen_memcpy(L_3, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5)) ? ___0_value : &___0_value), SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		NullCheck(L_2);
		String_t* L_4;
		L_4 = InvokerFuncInvoker1< String_t*, Il2CppFullySharedGenericAny >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)), il2cpp_rgctx_method(method->klass->rgctx_data, 6), L_2, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5)) ? L_3: *(void**)L_3));
		V_2 = L_4;
		String_t* L_5 = V_2;
		if (L_5)
		{
			goto IL_0019;
		}
	}
	{
		return (bool)1;
	}

IL_0019:
	{
		String_t* L_6 = V_2;
		String_t* L_7 = V_2;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_7, NULL);
		int32_t L_9;
		L_9 = ((  int32_t (*) (String_t*, int32_t, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))(L_6, 0, L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		V_3 = L_9;
		int32_t* L_10 = (int32_t*)(&__this->____numEntries);
		int32_t L_11;
		L_11 = Interlocked_Increment_m3C240C32E8D9544EC050B74D4F28EEB58F1F9309(L_10, NULL);
		V_0 = L_11;
		int32_t L_12 = V_0;
		if ((((int32_t)L_12) < ((int32_t)0)))
		{
			goto IL_0042;
		}
	}
	{
		int32_t L_13 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_14 = __this->____buckets;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0044;
		}
	}

IL_0042:
	{
		return (bool)0;
	}

IL_0044:
	{
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_15 = __this->____entries;
		int32_t L_16 = V_0;
		NullCheck(L_15);
		il2cpp_codegen_memcpy(L_17, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5)) ? ___0_value : &___0_value), SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		il2cpp_codegen_write_instance_field_data(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_15)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_16))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),0), L_17, SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_18 = __this->____entries;
		int32_t L_19 = V_0;
		NullCheck(L_18);
		int32_t L_20 = V_3;
		il2cpp_codegen_write_instance_field_data<int32_t>(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_18)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_19))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),1), L_20);
		Thread_MemoryBarrier_m83873F1E6CEB16C0781941141382DA874A36097D(NULL);
		V_1 = 0;
		goto IL_00b7;
	}

IL_0071:
	{
		int32_t L_21 = V_1;
		if (L_21)
		{
			goto IL_0095;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_22 = __this->____buckets;
		int32_t L_23 = V_3;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_24 = __this->____buckets;
		NullCheck(L_24);
		NullCheck(L_22);
		int32_t L_25 = V_0;
		int32_t L_26;
		L_26 = Interlocked_CompareExchange_mB06E8737D3DA41F9FFBC38A6D0583D515EFB5717(((L_22)->GetAddressAt(static_cast<il2cpp_array_size_t>(((int32_t)(L_23&((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_24)->max_length)), 1))))))), L_25, 0, NULL);
		V_1 = L_26;
		goto IL_00ae;
	}

IL_0095:
	{
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_27 = __this->____entries;
		int32_t L_28 = V_1;
		NullCheck(L_27);
		int32_t L_29 = V_0;
		int32_t L_30;
		L_30 = Interlocked_CompareExchange_mB06E8737D3DA41F9FFBC38A6D0583D515EFB5717((((int32_t*)il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_27)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_28))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),2)))), L_29, 0, NULL);
		V_1 = L_30;
	}

IL_00ae:
	{
		int32_t L_31 = V_1;
		if ((((int32_t)L_31) > ((int32_t)0)))
		{
			goto IL_00b7;
		}
	}
	{
		int32_t L_32 = V_1;
		return (bool)((((int32_t)L_32) == ((int32_t)0))? 1 : 0);
	}

IL_00b7:
	{
		int32_t L_33 = V_3;
		String_t* L_34 = V_2;
		String_t* L_35 = V_2;
		NullCheck(L_35);
		int32_t L_36;
		L_36 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_35, NULL);
		bool L_37;
		L_37 = ((  bool (*) (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D*, int32_t, String_t*, int32_t, int32_t, int32_t*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))(__this, L_33, L_34, 0, L_36, (&V_1), il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		if (!L_37)
		{
			goto IL_0071;
		}
	}
	{
		Il2CppFullySharedGenericAny* L_38 = ___1_newValue;
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_39 = __this->____entries;
		int32_t L_40 = V_1;
		NullCheck(L_39);
		il2cpp_codegen_memcpy(L_41, il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_39)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_40))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),0)), SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		il2cpp_codegen_memcpy((Il2CppFullySharedGenericAny*)L_38, L_41, SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		Il2CppCodeGenWriteBarrierForClass(il2cpp_rgctx_data(method->klass->rgctx_data, 5), (void**)(Il2CppFullySharedGenericAny*)L_38, (void*)L_41);
		return (bool)1;
	}
}
// Method Definition Index: 115035
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtableState_FindEntry_m480C6B27D99709A7E6CB50C907ACDEA057992BCD_gshared (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* __this, int32_t ___0_hashCode, String_t* ___1_key, int32_t ___2_index, int32_t ___3_count, int32_t* ___4_entryIndex, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5));
	const Il2CppFullySharedGenericAny L_16 = alloca(SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	String_t* V_2 = NULL;
	{
		int32_t* L_0 = ___4_entryIndex;
		int32_t L_1 = *((int32_t*)L_0);
		V_0 = L_1;
		int32_t L_2 = V_0;
		if (L_2)
		{
			goto IL_0020;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_3 = __this->____buckets;
		int32_t L_4 = ___0_hashCode;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_5 = __this->____buckets;
		NullCheck(L_5);
		NullCheck(L_3);
		int32_t L_6 = ((int32_t)(L_4&((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_5)->max_length)), 1))));
		int32_t L_7 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_1 = L_7;
		goto IL_00f9;
	}

IL_0020:
	{
		int32_t L_8 = V_0;
		V_1 = L_8;
		goto IL_00f9;
	}

IL_0027:
	{
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_9 = __this->____entries;
		int32_t L_10 = V_1;
		NullCheck(L_9);
		int32_t L_11 = *(int32_t*)il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_9)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_10))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),1));
		int32_t L_12 = ___0_hashCode;
		if ((!(((uint32_t)L_11) == ((uint32_t)L_12))))
		{
			goto IL_00e5;
		}
	}
	{
		ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD* L_13 = __this->____extractKey;
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_14 = __this->____entries;
		int32_t L_15 = V_1;
		NullCheck(L_14);
		il2cpp_codegen_memcpy(L_16, il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_14)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_15))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),0)), SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		NullCheck(L_13);
		String_t* L_17;
		L_17 = InvokerFuncInvoker1< String_t*, Il2CppFullySharedGenericAny >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)), il2cpp_rgctx_method(method->klass->rgctx_data, 6), L_13, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 5)) ? L_16: *(void**)L_16));
		V_2 = L_17;
		String_t* L_18 = V_2;
		if (L_18)
		{
			goto IL_00c8;
		}
	}
	{
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_19 = __this->____entries;
		int32_t L_20 = V_1;
		NullCheck(L_19);
		int32_t L_21 = *(int32_t*)il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_19)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_20))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),2));
		if ((((int32_t)L_21) <= ((int32_t)0)))
		{
			goto IL_00e5;
		}
	}
	{
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_22 = __this->____entries;
		int32_t L_23 = V_1;
		NullCheck(L_22);
		il2cpp_codegen_initobj((((Il2CppFullySharedGenericAny*)il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_22)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_23))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),0)))), SizeOf_TValue_tE0E843520D1B6FE8622D14458F0B584A2B7BCD70);
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_24 = __this->____entries;
		int32_t L_25 = V_1;
		NullCheck(L_24);
		int32_t L_26 = *(int32_t*)il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_24)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_25))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),2));
		V_1 = L_26;
		int32_t L_27 = V_0;
		if (L_27)
		{
			goto IL_00b4;
		}
	}
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_28 = __this->____buckets;
		int32_t L_29 = ___0_hashCode;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_30 = __this->____buckets;
		NullCheck(L_30);
		int32_t L_31 = V_1;
		NullCheck(L_28);
		(L_28)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)(L_29&((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_30)->max_length)), 1))))), (int32_t)L_31);
		goto IL_00f9;
	}

IL_00b4:
	{
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_32 = __this->____entries;
		int32_t L_33 = V_0;
		NullCheck(L_32);
		int32_t L_34 = V_1;
		il2cpp_codegen_write_instance_field_data<int32_t>(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_32)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_33))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),2), L_34);
		goto IL_00f9;
	}

IL_00c8:
	{
		int32_t L_35 = ___3_count;
		String_t* L_36 = V_2;
		NullCheck(L_36);
		int32_t L_37;
		L_37 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_36, NULL);
		if ((!(((uint32_t)L_35) == ((uint32_t)L_37))))
		{
			goto IL_00e5;
		}
	}
	{
		String_t* L_38 = ___1_key;
		int32_t L_39 = ___2_index;
		String_t* L_40 = V_2;
		int32_t L_41 = ___3_count;
		int32_t L_42;
		L_42 = String_CompareOrdinal_m8940CFAE90021ED8DA3F2DF8226941C9EEB2E32D(L_38, L_39, L_40, 0, L_41, NULL);
		if (L_42)
		{
			goto IL_00e5;
		}
	}
	{
		int32_t* L_43 = ___4_entryIndex;
		int32_t L_44 = V_1;
		*((int32_t*)L_43) = (int32_t)L_44;
		return (bool)1;
	}

IL_00e5:
	{
		int32_t L_45 = V_1;
		V_0 = L_45;
		EntryU5BU5D_tD3CC9C2488DC949FC30141F89404B8BDA9DB6CE4* L_46 = __this->____entries;
		int32_t L_47 = V_1;
		NullCheck(L_46);
		int32_t L_48 = *(int32_t*)il2cpp_codegen_get_instance_field_data_pointer(((Entry_t7F8922DC9D131FDA94BF956DD509FC395285A91E*)(L_46)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_47))), il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 4),2));
		V_1 = L_48;
	}

IL_00f9:
	{
		int32_t L_49 = V_1;
		if ((((int32_t)L_49) > ((int32_t)0)))
		{
			goto IL_0027;
		}
	}
	{
		int32_t* L_50 = ___4_entryIndex;
		int32_t L_51 = V_0;
		*((int32_t*)L_50) = (int32_t)L_51;
		return (bool)0;
	}
}
// Method Definition Index: 115036
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t XHashtableState_ComputeHashCode_m52BA0BD18441AD2A49C4E822AB76A7A5B7DC4B6D_gshared (String_t* ___0_key, int32_t ___1_index, int32_t ___2_count, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		V_0 = ((int32_t)352654597);
		int32_t L_0 = ___1_index;
		int32_t L_1 = ___2_count;
		V_1 = ((int32_t)il2cpp_codegen_add(L_0, L_1));
		int32_t L_2 = ___1_index;
		V_2 = L_2;
		goto IL_0020;
	}

IL_000e:
	{
		int32_t L_3 = V_0;
		int32_t L_4 = V_0;
		String_t* L_5 = ___0_key;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		Il2CppChar L_7;
		L_7 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_5, L_6, NULL);
		V_0 = ((int32_t)il2cpp_codegen_add(L_3, ((int32_t)(((int32_t)(L_4<<7))^(int32_t)L_7))));
		int32_t L_8 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_0020:
	{
		int32_t L_9 = V_2;
		int32_t L_10 = V_1;
		if ((((int32_t)L_9) < ((int32_t)L_10)))
		{
			goto IL_000e;
		}
	}
	{
		int32_t L_11 = V_0;
		int32_t L_12 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_11, ((int32_t)(L_12>>((int32_t)17)))));
		int32_t L_13 = V_0;
		int32_t L_14 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_13, ((int32_t)(L_14>>((int32_t)11)))));
		int32_t L_15 = V_0;
		int32_t L_16 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_15, ((int32_t)(L_16>>5))));
		int32_t L_17 = V_0;
		return ((int32_t)(L_17&((int32_t)2147483647LL)));
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 115026
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XHashtable_1__ctor_m9D005D3C7669B409F1E1B4F0863596FD91DB335C_gshared (XHashtable_1_t4C208624C5DAFD8858B7794DF15C5747BE4B3072* __this, ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* ___0_extractKey, int32_t ___1_capacity, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2((RuntimeObject*)__this, NULL);
		ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* L_0 = ___0_extractKey;
		int32_t L_1 = ___1_capacity;
		XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* L_2 = (XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 1));
		XHashtableState__ctor_m37E975C296D7D8CDF9ACAA9ABD7C4A0C82C427D3(L_2, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		__this->____state = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____state), (void*)L_2);
		return;
	}
}
// Method Definition Index: 115027
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtable_1_TryGetValue_mB91947F216CD72CEE9C38FA8EF56137E42817080_gshared (XHashtable_1_t4C208624C5DAFD8858B7794DF15C5747BE4B3072* __this, String_t* ___0_key, int32_t ___1_index, int32_t ___2_count, RuntimeObject** ___3_value, const RuntimeMethod* method) 
{
	{
		XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* L_0 = __this->____state;
		String_t* L_1 = ___0_key;
		int32_t L_2 = ___1_index;
		int32_t L_3 = ___2_count;
		RuntimeObject** L_4 = ___3_value;
		NullCheck(L_0);
		bool L_5;
		L_5 = XHashtableState_TryGetValue_m22BFB31B1A4E2CEDE4CA7133F4A0B50B9E514308(L_0, L_1, L_2, L_3, L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		return L_5;
	}
}
// Method Definition Index: 115028
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* XHashtable_1_Add_m4CE3AB9A64E8EBADEC48510932751F7C6D5581A0_gshared (XHashtable_1_t4C208624C5DAFD8858B7794DF15C5747BE4B3072* __this, RuntimeObject* ___0_value, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	XHashtable_1_t4C208624C5DAFD8858B7794DF15C5747BE4B3072* V_1 = NULL;
	bool V_2 = false;
	XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* V_3 = NULL;

IL_0000:
	{
		XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* L_0 = __this->____state;
		RuntimeObject* L_1 = ___0_value;
		NullCheck(L_0);
		bool L_2;
		L_2 = XHashtableState_TryAdd_m951A9A914307495745E2B33DB0BA6583FB4060A1(L_0, L_1, (&V_0), il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		if (!L_2)
		{
			goto IL_0012;
		}
	}
	{
		RuntimeObject* L_3 = V_0;
		return L_3;
	}

IL_0012:
	{
		V_1 = __this;
		V_2 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0038:
			{
				{
					bool L_4 = V_2;
					if (!L_4)
					{
						goto IL_0041;
					}
				}
				{
					XHashtable_1_t4C208624C5DAFD8858B7794DF15C5747BE4B3072* L_5 = V_1;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA((RuntimeObject*)L_5, NULL);
				}

IL_0041:
				{
					return;
				}
			}
		});
		try
		{
			XHashtable_1_t4C208624C5DAFD8858B7794DF15C5747BE4B3072* L_6 = V_1;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149((RuntimeObject*)L_6, (&V_2), NULL);
			XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* L_7 = __this->____state;
			NullCheck(L_7);
			XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* L_8;
			L_8 = XHashtableState_Resize_mDB3BA5C327EF6A86F6CE58B59E1D7430E62532C5(L_7, il2cpp_rgctx_method(method->klass->rgctx_data, 8));
			V_3 = L_8;
			Thread_MemoryBarrier_m83873F1E6CEB16C0781941141382DA874A36097D(NULL);
			XHashtableState_tA4D9621B10532B31291D60ED7E6B08342FAA537A* L_9 = V_3;
			__this->____state = L_9;
			Il2CppCodeGenWriteBarrier((void**)(&__this->____state), (void*)L_9);
			goto IL_0000;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}
	il2cpp_codegen_no_return();
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 115026
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XHashtable_1__ctor_m76AD29BB3D4A65A3071FDFCC0AD7F927FC6051B7_gshared (XHashtable_1_t781B821CC6AC13BED190536310819EB7FD1463D0* __this, ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD* ___0_extractKey, int32_t ___1_capacity, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2((RuntimeObject*)__this, NULL);
		ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD* L_0 = ___0_extractKey;
		int32_t L_1 = ___1_capacity;
		XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* L_2 = (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 1));
		((  void (*) (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D*, ExtractKeyDelegate_t0FCB0690B76E40F52DC9D05708A8FC488624E3CD*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))(L_2, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		__this->____state = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____state), (void*)L_2);
		return;
	}
}
// Method Definition Index: 115027
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XHashtable_1_TryGetValue_m2AE37A0F57ADCA202E17A64CCAF4D0F37A070A24_gshared (XHashtable_1_t781B821CC6AC13BED190536310819EB7FD1463D0* __this, String_t* ___0_key, int32_t ___1_index, int32_t ___2_count, Il2CppFullySharedGenericAny* ___3_value, const RuntimeMethod* method) 
{
	{
		XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* L_0 = __this->____state;
		String_t* L_1 = ___0_key;
		int32_t L_2 = ___1_index;
		int32_t L_3 = ___2_count;
		Il2CppFullySharedGenericAny* L_4 = ___3_value;
		NullCheck(L_0);
		bool L_5;
		L_5 = ((  bool (*) (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D*, String_t*, int32_t, int32_t, Il2CppFullySharedGenericAny*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_0, L_1, L_2, L_3, L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		return L_5;
	}
}
// Method Definition Index: 115028
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XHashtable_1_Add_mB4B8BF6CA81EE97D92FEE9D365A8FFB15168AE00_gshared (XHashtable_1_t781B821CC6AC13BED190536310819EB7FD1463D0* __this, Il2CppFullySharedGenericAny ___0_value, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TValue_t3953344BBD5AABD452C9834A9E3F75B5A767B1A7 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 6));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TValue_t3953344BBD5AABD452C9834A9E3F75B5A767B1A7);
	const Il2CppFullySharedGenericAny L_3 = L_1;
	Il2CppFullySharedGenericAny V_0 = alloca(SizeOf_TValue_t3953344BBD5AABD452C9834A9E3F75B5A767B1A7);
	memset(V_0, 0, SizeOf_TValue_t3953344BBD5AABD452C9834A9E3F75B5A767B1A7);
	XHashtable_1_t781B821CC6AC13BED190536310819EB7FD1463D0* V_1 = NULL;
	bool V_2 = false;
	XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* V_3 = NULL;

IL_0000:
	{
		XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* L_0 = __this->____state;
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 6)) ? ___0_value : &___0_value), SizeOf_TValue_t3953344BBD5AABD452C9834A9E3F75B5A767B1A7);
		NullCheck(L_0);
		bool L_2;
		L_2 = InvokerFuncInvoker2< bool, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)), il2cpp_rgctx_method(method->klass->rgctx_data, 7), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 6)) ? L_1: *(void**)L_1), (Il2CppFullySharedGenericAny*)V_0);
		if (!L_2)
		{
			goto IL_0012;
		}
	}
	{
		il2cpp_codegen_memcpy(L_3, V_0, SizeOf_TValue_t3953344BBD5AABD452C9834A9E3F75B5A767B1A7);
		il2cpp_codegen_memcpy(il2cppRetVal, L_3, SizeOf_TValue_t3953344BBD5AABD452C9834A9E3F75B5A767B1A7);
		return;
	}

IL_0012:
	{
		V_1 = __this;
		V_2 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0038:
			{
				{
					bool L_4 = V_2;
					if (!L_4)
					{
						goto IL_0041;
					}
				}
				{
					XHashtable_1_t781B821CC6AC13BED190536310819EB7FD1463D0* L_5 = V_1;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA((RuntimeObject*)L_5, NULL);
				}

IL_0041:
				{
					return;
				}
			}
		});
		try
		{
			XHashtable_1_t781B821CC6AC13BED190536310819EB7FD1463D0* L_6 = V_1;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149((RuntimeObject*)L_6, (&V_2), NULL);
			XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* L_7 = __this->____state;
			NullCheck(L_7);
			XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* L_8;
			L_8 = ((  XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* (*) (XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 8)))(L_7, il2cpp_rgctx_method(method->klass->rgctx_data, 8));
			V_3 = L_8;
			Thread_MemoryBarrier_m83873F1E6CEB16C0781941141382DA874A36097D(NULL);
			XHashtableState_t34177FC58180B0A7A606129FC1FA6AF4C373043D* L_9 = V_3;
			__this->____state = L_9;
			Il2CppCodeGenWriteBarrier((void**)(&__this->____state), (void*)L_9);
			goto IL_0000;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}
	il2cpp_codegen_no_return();
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80954
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip__ctor_m2CF876688E3626B7099110BD7CFEA4EF820B7CEE_gshared (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* __this, ZipObservable_1_tCF96E17B3CE750A3553A6CE43DA7472BC77222B2* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:210>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:216>
		RuntimeObject* L_1 = ___1_observer;
		RuntimeObject* L_2 = ___2_cancel;
		((  void (*) (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, L_1, L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:218>
		ZipObservable_1_tCF96E17B3CE750A3553A6CE43DA7472BC77222B2* L_3 = ___0_parent;
		__this->___parent = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:219>
		return;
	}
}
// Method Definition Index: 80955
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zip_Run_m30A87BED860C57ADED1EFE743A5099C6B304C7A4_gshared (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:223>
		ZipObservable_1_tCF96E17B3CE750A3553A6CE43DA7472BC77222B2* L_0 = __this->___parent;
		NullCheck(L_0);
		IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035* L_1 = L_0->___sources;
		NullCheck(L_1);
		__this->___length = ((int32_t)(((RuntimeArray*)L_1)->max_length));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:224>
		int32_t L_2 = __this->___length;
		Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3* L_3 = (Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3*)(Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3*)SZArrayNew(il2cpp_rgctx_data(method->klass->rgctx_data, 6), (uint32_t)L_2);
		__this->___queues = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___queues), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:225>
		int32_t L_4 = __this->___length;
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_5 = (BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4*)(BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4*)SZArrayNew(BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4_il2cpp_TypeInfo_var, (uint32_t)L_4);
		__this->___isDone = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___isDone), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:227>
		V_1 = 0;
		goto IL_004a;
	}

IL_0039:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:229>
		Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3* L_6 = __this->___queues;
		int32_t L_7 = V_1;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 8));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		NullCheck(L_6);
		ArrayElementTypeCheck (L_6, L_8);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)L_8);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:227>
		int32_t L_9 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_9, 1));
	}

IL_004a:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:227>
		int32_t L_10 = V_1;
		int32_t L_11 = __this->___length;
		if ((((int32_t)L_10) < ((int32_t)L_11)))
		{
			goto IL_0039;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:232>
		int32_t L_12 = __this->___length;
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_13 = (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)SZArrayNew(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_add(L_12, 1)));
		V_0 = L_13;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:233>
		V_2 = 0;
		goto IL_0087;
	}

IL_0065:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:235>
		ZipObservable_1_tCF96E17B3CE750A3553A6CE43DA7472BC77222B2* L_14 = __this->___parent;
		NullCheck(L_14);
		IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035* L_15 = L_14->___sources;
		int32_t L_16 = V_2;
		NullCheck(L_15);
		int32_t L_17 = L_16;
		RuntimeObject* L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		V_3 = L_18;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:236>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_19 = V_0;
		int32_t L_20 = V_2;
		RuntimeObject* L_21 = V_3;
		int32_t L_22 = V_2;
		ZipObserver_tEA117F108743D9CF50FE3CBC8B616BB5C58F6AA2* L_23 = (ZipObserver_tEA117F108743D9CF50FE3CBC8B616BB5C58F6AA2*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 10));
		((  void (*) (ZipObserver_tEA117F108743D9CF50FE3CBC8B616BB5C58F6AA2*, Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_23, __this, L_22, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		NullCheck(L_21);
		RuntimeObject* L_24;
		L_24 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 12), L_21, (RuntimeObject*)L_23);
		NullCheck(L_19);
		ArrayElementTypeCheck (L_19, L_24);
		(L_19)->SetAt(static_cast<il2cpp_array_size_t>(L_20), (RuntimeObject*)L_24);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:233>
		int32_t L_25 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_25, 1));
	}

IL_0087:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:233>
		int32_t L_26 = V_2;
		int32_t L_27 = __this->___length;
		if ((((int32_t)L_26) < ((int32_t)L_27)))
		{
			goto IL_0065;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:239>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:240>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:241>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:242>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:243>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:244>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:245>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:246>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:247>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:248>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:249>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_28 = V_0;
		int32_t L_29 = __this->___length;
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_30 = (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)il2cpp_codegen_object_new(Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		Action__ctor_mBDC7B0B4A3F583B64C2896F01BDED360772F67DC(L_30, (RuntimeObject*)__this, (intptr_t)((void*)il2cpp_rgctx_method(method->klass->rgctx_data, 15)), NULL);
		il2cpp_codegen_runtime_class_init_inline(Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		RuntimeObject* L_31;
		L_31 = Disposable_Create_m8FC5E161705A5AB1D0FD89067783648C9A6B1BF1(L_30, NULL);
		NullCheck(L_28);
		ArrayElementTypeCheck (L_28, L_31);
		(L_28)->SetAt(static_cast<il2cpp_array_size_t>(L_29), (RuntimeObject*)L_31);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:251>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_32 = V_0;
		RuntimeObject* L_33;
		L_33 = StableCompositeDisposable_CreateUnsafe_m61E9E95FD914CF4A0EB267CBE46D63AB1066FD08(L_32, NULL);
		return (RuntimeObject*)L_33;
	}
}
// Method Definition Index: 80956
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_Dequeue_m397187375D7AA9FADA0E308368C66A576F40DABE_gshared (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_T_tE0320821E874BDFEA680D8E36B709B9201E86966 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 23));
	const Il2CppFullySharedGenericAny L_28 = alloca(SizeOf_T_tE0320821E874BDFEA680D8E36B709B9201E86966);
	bool V_0 = false;
	__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* V_1 = NULL;
	int32_t V_2 = 0;
	bool V_3 = false;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:257>
		V_0 = (bool)1;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:258>
		V_2 = 0;
		goto IL_001d;
	}

IL_0006:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:260>
		Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3* L_0 = __this->___queues;
		int32_t L_1 = V_2;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		NullCheck(L_3);
		int32_t L_4;
		L_4 = ((  int32_t (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 16)))(L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 16));
		if (L_4)
		{
			goto IL_0019;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:262>
		V_0 = (bool)0;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:263>
		goto IL_0026;
	}

IL_0019:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:258>
		int32_t L_5 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
	}

IL_001d:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:258>
		int32_t L_6 = V_2;
		int32_t L_7 = __this->___length;
		if ((((int32_t)L_6) < ((int32_t)L_7)))
		{
			goto IL_0006;
		}
	}

IL_0026:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:267>
		bool L_8 = V_0;
		if (L_8)
		{
			goto IL_006f;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:269>
		V_3 = (bool)1;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:270>
		V_4 = 0;
		goto IL_004a;
	}

IL_0030:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:272>
		int32_t L_9 = V_4;
		int32_t L_10 = ___0_index;
		if ((((int32_t)L_9) == ((int32_t)L_10)))
		{
			goto IL_0044;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:273>
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_11 = __this->___isDone;
		int32_t L_12 = V_4;
		NullCheck(L_11);
		int32_t L_13 = L_12;
		uint8_t L_14 = (uint8_t)(L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_13));
		if (L_14)
		{
			goto IL_0044;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:275>
		V_3 = (bool)0;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:276>
		goto IL_0054;
	}

IL_0044:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:270>
		int32_t L_15 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_15, 1));
	}

IL_004a:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:270>
		int32_t L_16 = V_4;
		int32_t L_17 = __this->___length;
		if ((((int32_t)L_16) < ((int32_t)L_17)))
		{
			goto IL_0030;
		}
	}

IL_0054:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:280>
		bool L_18 = V_3;
		if (!L_18)
		{
			goto IL_006e;
		}
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0066:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:283>
				NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this);
				((  void (*) (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 20)))((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 20));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:283>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:282>
			RuntimeObject* L_19 = ((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_19);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_19);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:282>
			goto IL_006d;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_006d:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:284>
		return;
	}

IL_006e:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:288>
		return;
	}

IL_006f:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:292>
		int32_t L_20 = __this->___length;
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_21 = (__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC*)(__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC*)SZArrayNew(il2cpp_rgctx_data(method->klass->rgctx_data, 21), (uint32_t)L_20);
		V_1 = L_21;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:293>
		V_5 = 0;
		goto IL_009c;
	}

IL_0080:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:295>
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_22 = V_1;
		int32_t L_23 = V_5;
		Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3* L_24 = __this->___queues;
		int32_t L_25 = V_5;
		NullCheck(L_24);
		int32_t L_26 = L_25;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_27 = (L_24)->GetAt(static_cast<il2cpp_array_size_t>(L_26));
		NullCheck(L_27);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 22)), il2cpp_rgctx_method(method->klass->rgctx_data, 22), L_27, (Il2CppFullySharedGenericAny*)L_28);
		NullCheck(L_22);
		il2cpp_codegen_memcpy((L_22)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_23)), L_28, SizeOf_T_tE0320821E874BDFEA680D8E36B709B9201E86966);
		Il2CppCodeGenWriteBarrierForClass(il2cpp_rgctx_data(method->klass->rgctx_data, 23), (void**)(L_22)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_23)), (void*)L_28);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:293>
		int32_t L_29 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_29, 1));
	}

IL_009c:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:293>
		int32_t L_30 = V_5;
		int32_t L_31 = __this->___length;
		if ((((int32_t)L_30) < ((int32_t)L_31)))
		{
			goto IL_0080;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:298>
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_32 = V_1;
		NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this);
		VirtualActionInvoker1Invoker< RuntimeObject* >::Invoke(8, (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, (RuntimeObject*)L_32);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:299>
		return;
	}
}
// Method Definition Index: 80957
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnNext_m7F31C9BF2B144B5AE3BF753809976B63D27BDFF0_gshared (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* __this, RuntimeObject* ___0_value, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:303>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		RuntimeObject* L_1 = ___0_value;
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:304>
		return;
	}
}
// Method Definition Index: 80958
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnError_mB2E6586A12FAD2D1607E5837D4DA4B396A8737D0_gshared (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:309>
				NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this);
				((  void (*) (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 20)))((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 20));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:309>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:308>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:308>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:310>
		return;
	}
}
// Method Definition Index: 80959
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnCompleted_m7C0A5FCCAD62A5543F3A2B5612A012A75FFFD78D_gshared (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:315>
				NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this);
				((  void (*) (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 20)))((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 20));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:315>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:314>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:314>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:316>
		return;
	}
}
// Method Definition Index: 80960
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_U3CRunU3Eb__6_0_m91A13828F81755CA1A978D58AC423725A223392C_gshared (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	int32_t V_2 = 0;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:241>
		RuntimeObject* L_0 = __this->___gate;
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0031:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_003a;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_003a:
				{
					return;
				}
			}
		});
		try
		{
			{
				RuntimeObject* L_3 = V_0;
				Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:243>
				V_2 = 0;
				goto IL_0026_1;
			}

IL_0015_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:245>
				Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3* L_4 = __this->___queues;
				int32_t L_5 = V_2;
				NullCheck(L_4);
				int32_t L_6 = L_5;
				Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:246>
				NullCheck(L_7);
				((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 29)))(L_7, il2cpp_rgctx_method(method->klass->rgctx_data, 29));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:243>
				int32_t L_8 = V_2;
				V_2 = ((int32_t)il2cpp_codegen_add(L_8, 1));
			}

IL_0026_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:243>
				int32_t L_9 = V_2;
				int32_t L_10 = __this->___length;
				if ((((int32_t)L_9) < ((int32_t)L_10)))
				{
					goto IL_0015_1;
				}
			}
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:248>
				goto IL_003b;
			}
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_003b:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:249>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80937
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip__ctor_mE4EB323DC77CE1A83053548A1B03A4BEB3ECAFEB_gshared (Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746* __this, ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:36>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:37>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_1 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 1));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))(L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		__this->___leftQ = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___leftQ), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:39>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 3));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 4)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 4));
		__this->___rightQ = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___rightQ), (void*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:43>
		RuntimeObject* L_3 = ___1_observer;
		RuntimeObject* L_4 = ___2_cancel;
		((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, L_3, L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:45>
		ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* L_5 = ___0_parent;
		__this->___parent = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:46>
		return;
	}
}
// Method Definition Index: 80938
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zip_Run_m842DCDC910956AE9D8BE1B3089554C901A2F049F_gshared (Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:50>
		ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* L_0 = __this->___parent;
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->___left;
		LeftZipObserver_tF654ECFF4ABF554CCB22A1BD44613E0BB6A39ACD* L_2 = (LeftZipObserver_tF654ECFF4ABF554CCB22A1BD44613E0BB6A39ACD*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 10));
		((  void (*) (LeftZipObserver_tF654ECFF4ABF554CCB22A1BD44613E0BB6A39ACD*, Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_2, __this, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		NullCheck(L_1);
		RuntimeObject* L_3;
		L_3 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 9), L_1, (RuntimeObject*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:51>
		ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* L_4 = __this->___parent;
		NullCheck(L_4);
		RuntimeObject* L_5 = L_4->___right;
		RightZipObserver_t9BB70D85E6615F51DC252B76D25F1158B0963E3F* L_6 = (RightZipObserver_t9BB70D85E6615F51DC252B76D25F1158B0963E3F*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 15));
		((  void (*) (RightZipObserver_t9BB70D85E6615F51DC252B76D25F1158B0963E3F*, Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 16)))(L_6, __this, il2cpp_rgctx_method(method->klass->rgctx_data, 16));
		NullCheck(L_5);
		RuntimeObject* L_7;
		L_7 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 14), L_5, (RuntimeObject*)L_6);
		V_0 = L_7;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:53>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:54>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:55>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:56>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:57>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:58>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:59>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:60>
		RuntimeObject* L_8 = V_0;
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_9 = (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)il2cpp_codegen_object_new(Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		Action__ctor_mBDC7B0B4A3F583B64C2896F01BDED360772F67DC(L_9, (RuntimeObject*)__this, (intptr_t)((void*)il2cpp_rgctx_method(method->klass->rgctx_data, 19)), NULL);
		il2cpp_codegen_runtime_class_init_inline(Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		RuntimeObject* L_10;
		L_10 = Disposable_Create_m8FC5E161705A5AB1D0FD89067783648C9A6B1BF1(L_9, NULL);
		RuntimeObject* L_11;
		L_11 = StableCompositeDisposable_Create_m69159E99C420E2BBE360CC54400E67127D36E724(L_3, L_8, L_10, NULL);
		return (RuntimeObject*)L_11;
	}
}
// Method Definition Index: 80939
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_Dequeue_m7F0580F37A6D5CA67305C366460237ECDC9EC9E0_gshared (Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746* __this, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TLeft_tA123DF1527A2F79CE1891E77E85622953F568BBC = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 23));
	const uint32_t SizeOf_TRight_t5C9840519B2276858AFF4E3BE654608199F1B276 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 25));
	const uint32_t SizeOf_TResult_t4E65F558D1384ED40EA3BC0939051D22C0E700ED = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 32));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_TLeft_tA123DF1527A2F79CE1891E77E85622953F568BBC);
	const Il2CppFullySharedGenericAny L_13 = L_5;
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_TRight_t5C9840519B2276858AFF4E3BE654608199F1B276);
	const Il2CppFullySharedGenericAny L_14 = L_7;
	const Il2CppFullySharedGenericAny L_15 = alloca(SizeOf_TResult_t4E65F558D1384ED40EA3BC0939051D22C0E700ED);
	const Il2CppFullySharedGenericAny L_19 = L_15;
	Il2CppFullySharedGenericAny V_0 = alloca(SizeOf_TLeft_tA123DF1527A2F79CE1891E77E85622953F568BBC);
	memset(V_0, 0, SizeOf_TLeft_tA123DF1527A2F79CE1891E77E85622953F568BBC);
	Il2CppFullySharedGenericAny V_1 = alloca(SizeOf_TRight_t5C9840519B2276858AFF4E3BE654608199F1B276);
	memset(V_1, 0, SizeOf_TRight_t5C9840519B2276858AFF4E3BE654608199F1B276);
	Il2CppFullySharedGenericAny V_2 = alloca(SizeOf_TResult_t4E65F558D1384ED40EA3BC0939051D22C0E700ED);
	memset(V_2, 0, SizeOf_TResult_t4E65F558D1384ED40EA3BC0939051D22C0E700ED);
	Exception_t* V_3 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:70>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_0 = __this->___leftQ;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = ((  int32_t (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 20)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 20));
		if (!L_1)
		{
			goto IL_0034;
		}
	}
	{
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___rightQ;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = ((  int32_t (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 21)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 21));
		if (!L_3)
		{
			goto IL_0034;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:72>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___leftQ;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 22)), il2cpp_rgctx_method(method->klass->rgctx_data, 22), L_4, (Il2CppFullySharedGenericAny*)L_5);
		il2cpp_codegen_memcpy(V_0, L_5, SizeOf_TLeft_tA123DF1527A2F79CE1891E77E85622953F568BBC);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:73>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___rightQ;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 24)), il2cpp_rgctx_method(method->klass->rgctx_data, 24), L_6, (Il2CppFullySharedGenericAny*)L_7);
		il2cpp_codegen_memcpy(V_1, L_7, SizeOf_TRight_t5C9840519B2276858AFF4E3BE654608199F1B276);
		goto IL_005d;
	}

IL_0034:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:75>
		bool L_8 = __this->___leftCompleted;
		if (L_8)
		{
			goto IL_0044;
		}
	}
	{
		bool L_9 = __this->___rightCompleted;
		if (!L_9)
		{
			goto IL_005c;
		}
	}

IL_0044:
	{
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0054:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:78>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 29)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 29));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:78>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:77>
			RuntimeObject* L_10 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_10);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 5), L_10);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:77>
			goto IL_005b;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_005b:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:79>
		return;
	}

IL_005c:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:83>
		return;
	}

IL_005d:
	{
	}
	try
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:88>
		ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* L_11 = __this->___parent;
		NullCheck(L_11);
		Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* L_12 = L_11->___selector;
		il2cpp_codegen_memcpy(L_13, V_0, SizeOf_TLeft_tA123DF1527A2F79CE1891E77E85622953F568BBC);
		il2cpp_codegen_memcpy(L_14, V_1, SizeOf_TRight_t5C9840519B2276858AFF4E3BE654608199F1B276);
		NullCheck(L_12);
		InvokerActionInvoker3< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 31)), il2cpp_rgctx_method(method->klass->rgctx_data, 31), L_12, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 23)) ? L_13: *(void**)L_13), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 25)) ? L_14: *(void**)L_14), (Il2CppFullySharedGenericAny*)L_15);
		il2cpp_codegen_memcpy(V_2, L_15, SizeOf_TResult_t4E65F558D1384ED40EA3BC0939051D22C0E700ED);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:89>
		goto IL_008d;
	}
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0073;
		}
		throw e;
	}

CATCH_0073:
	{
		{
			Exception_t* L_16 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));;
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:90>
			V_3 = L_16;
		}
		{
			auto __finallyBlock = il2cpp::utils::Finally([&]
			{

FINALLY_0084:
				{
					//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:93>
					NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
					((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 29)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 29));
					//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:93>
					return;
				}
			});
			try
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:92>
				RuntimeObject* L_17 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
				il2cpp_codegen_memory_barrier();
				Exception_t* L_18 = V_3;
				NullCheck(L_17);
				InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 5), L_17, L_18);
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:92>
				goto IL_008b;
			}
			catch(Il2CppExceptionWrapper& e)
			{
				__finallyBlock.StoreException(e.ex);
			}
		}

IL_008b:
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:94>
			IL2CPP_POP_ACTIVE_EXCEPTION(Exception_t*);
			goto IL_0094;
		}
	}

IL_008d:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:97>
		il2cpp_codegen_memcpy(L_19, V_2, SizeOf_TResult_t4E65F558D1384ED40EA3BC0939051D22C0E700ED);
		NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
		VirtualActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(8, (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 32)) ? L_19: *(void**)L_19));
	}

IL_0094:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:98>
		return;
	}
}
// Method Definition Index: 80940
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnNext_m69F62F291B53410328F5CB6AF9AE12A9A24D4D9E_gshared (Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TResult_t4E65F558D1384ED40EA3BC0939051D22C0E700ED = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 32));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TResult_t4E65F558D1384ED40EA3BC0939051D22C0E700ED);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:102>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 32)) ? ___0_value : &___0_value), SizeOf_TResult_t4E65F558D1384ED40EA3BC0939051D22C0E700ED);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 5), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 32)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:103>
		return;
	}
}
// Method Definition Index: 80941
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnError_m8F25DE971A5FB4E626B7B174C8F11246219EF781_gshared (Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:108>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 29)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 29));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:108>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:107>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 5), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:107>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:109>
		return;
	}
}
// Method Definition Index: 80942
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnCompleted_m56D9B4C0B5B3315A7B74ED7210EE2DB8811A4935_gshared (Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:114>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 29)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 29));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:114>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:113>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 5), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:113>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:115>
		return;
	}
}
// Method Definition Index: 80943
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_U3CRunU3Eb__7_0_mB9543A5015975113A396ABFEAFF25172EF7ADAF4_gshared (Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:55>
		RuntimeObject* L_0 = __this->___gate;
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0029:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_0032;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_0032:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:57>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___leftQ;
			NullCheck(L_4);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 36)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 36));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:58>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_5 = __this->___rightQ;
			NullCheck(L_5);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 37)))(L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 37));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:59>
			goto IL_0033;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0033:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:60>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80967
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip__ctor_m892AF3D5EDD35CA6D66CC115F22239591941A174_gshared (Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC* __this, ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:406>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:407>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_1 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 1));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))(L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		__this->___q1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q1), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:408>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 3));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 4)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 4));
		__this->___q2 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q2), (void*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:409>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_3 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 5));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))(L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		__this->___q3 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q3), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:412>
		RuntimeObject* L_4 = ___1_observer;
		RuntimeObject* L_5 = ___2_cancel;
		((  void (*) (NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 8)))((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this, L_4, L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 8));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:414>
		ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* L_6 = ___0_parent;
		__this->___parent = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_6);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:415>
		return;
	}
}
// Method Definition Index: 80968
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zip_Run_mAD36379517E2BE9C8D02656C239F9E450765D392_gshared (Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:419>
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_0 = (ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*)(ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*)SZArrayNew(ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var, (uint32_t)3);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_1 = L_0;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___q1;
		NullCheck(L_1);
		ArrayElementTypeCheck (L_1, L_2);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_2);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_3 = L_1;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q2;
		NullCheck(L_3);
		ArrayElementTypeCheck (L_3, L_4);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_4);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_5 = L_3;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_6);
		NullCheck((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this);
		((  void (*) (NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*, ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this, L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:420>
		ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* L_7 = __this->___parent;
		NullCheck(L_7);
		RuntimeObject* L_8 = L_7->___source1;
		RuntimeObject* L_9 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_10 = __this->___q1;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_11 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 14));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 15)))(L_11, L_9, (RuntimeObject*)__this, 0, L_10, il2cpp_rgctx_method(method->klass->rgctx_data, 15));
		NullCheck(L_8);
		RuntimeObject* L_12;
		L_12 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 13), L_8, (RuntimeObject*)L_11);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:421>
		ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* L_13 = __this->___parent;
		NullCheck(L_13);
		RuntimeObject* L_14 = L_13->___source2;
		RuntimeObject* L_15 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_16 = __this->___q2;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_17 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 19));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 20)))(L_17, L_15, (RuntimeObject*)__this, 1, L_16, il2cpp_rgctx_method(method->klass->rgctx_data, 20));
		NullCheck(L_14);
		RuntimeObject* L_18;
		L_18 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 18), L_14, (RuntimeObject*)L_17);
		V_0 = L_18;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:422>
		ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* L_19 = __this->___parent;
		NullCheck(L_19);
		RuntimeObject* L_20 = L_19->___source3;
		RuntimeObject* L_21 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_22 = __this->___q3;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_23 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 24));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 25)))(L_23, L_21, (RuntimeObject*)__this, 2, L_22, il2cpp_rgctx_method(method->klass->rgctx_data, 25));
		NullCheck(L_20);
		RuntimeObject* L_24;
		L_24 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 23), L_20, (RuntimeObject*)L_23);
		V_1 = L_24;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:424>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:425>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:426>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:427>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:428>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:429>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:430>
		RuntimeObject* L_25 = V_0;
		RuntimeObject* L_26 = V_1;
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_27 = (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)il2cpp_codegen_object_new(Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		Action__ctor_mBDC7B0B4A3F583B64C2896F01BDED360772F67DC(L_27, (RuntimeObject*)__this, (intptr_t)((void*)il2cpp_rgctx_method(method->klass->rgctx_data, 28)), NULL);
		il2cpp_codegen_runtime_class_init_inline(Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		RuntimeObject* L_28;
		L_28 = Disposable_Create_m8FC5E161705A5AB1D0FD89067783648C9A6B1BF1(L_27, NULL);
		RuntimeObject* L_29;
		L_29 = StableCompositeDisposable_Create_mEF2811969D2F81FD06130ED8A4A48D26E42F9B94(L_12, L_25, L_26, L_28, NULL);
		return (RuntimeObject*)L_29;
	}
}
// Method Definition Index: 80969
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_GetResult_m9E02DDDEDB83DF0841560589740D07B1A4DD9A63_gshared (Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t1BB644B037D6BE59F0B0C6E4532463BDFFE1A2AB = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 37));
	const uint32_t SizeOf_T1_t8D945B0D7F624E824253F05BAF7D1A49D694C33B = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 31));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T1_t8D945B0D7F624E824253F05BAF7D1A49D694C33B);
	const uint32_t SizeOf_T2_tCFA54844647F1F882DCFC7234A32AB197453A08C = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 33));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T2_tCFA54844647F1F882DCFC7234A32AB197453A08C);
	const uint32_t SizeOf_T3_t91D5848DCDC81497DE7D2CFDB2F1498CFBC3C0D0 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 35));
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_T3_t91D5848DCDC81497DE7D2CFDB2F1498CFBC3C0D0);
	const Il2CppFullySharedGenericAny L_8 = alloca(SizeOf_TR_t1BB644B037D6BE59F0B0C6E4532463BDFFE1A2AB);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:435>
		ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* L_0 = __this->___parent;
		NullCheck(L_0);
		ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* L_1 = L_0->___resultSelector;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___q1;
		NullCheck(L_2);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 30)), il2cpp_rgctx_method(method->klass->rgctx_data, 30), L_2, (Il2CppFullySharedGenericAny*)L_3);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q2;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 32)), il2cpp_rgctx_method(method->klass->rgctx_data, 32), L_4, (Il2CppFullySharedGenericAny*)L_5);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 34)), il2cpp_rgctx_method(method->klass->rgctx_data, 34), L_6, (Il2CppFullySharedGenericAny*)L_7);
		NullCheck(L_1);
		InvokerActionInvoker4< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 36)), il2cpp_rgctx_method(method->klass->rgctx_data, 36), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 31)) ? L_3: *(void**)L_3), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 33)) ? L_5: *(void**)L_5), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 35)) ? L_7: *(void**)L_7), (Il2CppFullySharedGenericAny*)L_8);
		il2cpp_codegen_memcpy(il2cppRetVal, L_8, SizeOf_TR_t1BB644B037D6BE59F0B0C6E4532463BDFFE1A2AB);
		return;
	}
}
// Method Definition Index: 80970
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnNext_mABED9D1B057EAC9B62400EFB9A806A821D8DF2E2_gshared (Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t1BB644B037D6BE59F0B0C6E4532463BDFFE1A2AB = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 37));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TR_t1BB644B037D6BE59F0B0C6E4532463BDFFE1A2AB);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:440>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 37)) ? ___0_value : &___0_value), SizeOf_TR_t1BB644B037D6BE59F0B0C6E4532463BDFFE1A2AB);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 7), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 37)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:441>
		return;
	}
}
// Method Definition Index: 80971
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnError_mCF1B94B0D9A156D986EA9035A991C2DFB7B19306_gshared (Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:446>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 42)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 42));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:446>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:445>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 7), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:445>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:447>
		return;
	}
}
// Method Definition Index: 80972
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnCompleted_m1E2DDDF41C856B5EF977BE519C89F156F42EE82C_gshared (Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:452>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 42)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 42));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:452>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:451>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 7), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:451>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:453>
		return;
	}
}
// Method Definition Index: 80973
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_U3CRunU3Eb__6_0_m4E73569F9A4C94814878C55FDBFB8453780FCFCC_gshared (Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:426>
		RuntimeObject* L_0 = __this->___gate;
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0034:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_003d;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_003d:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:428>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q1;
			NullCheck(L_4);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 44)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 44));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:428>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_5 = __this->___q2;
			NullCheck(L_5);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 45)))(L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 45));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:428>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
			NullCheck(L_6);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 46)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 46));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:429>
			goto IL_003e;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_003e:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:430>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80976
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip__ctor_m14452A4528F45C6C0EBE1C684E066AEE8C64B964_gshared (Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228* __this, ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:494>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:495>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_1 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 1));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))(L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		__this->___q1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q1), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:496>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 3));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 4)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 4));
		__this->___q2 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q2), (void*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:497>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_3 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 5));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))(L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		__this->___q3 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q3), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:498>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 7));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 8)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 8));
		__this->___q4 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q4), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:501>
		RuntimeObject* L_5 = ___1_observer;
		RuntimeObject* L_6 = ___2_cancel;
		((  void (*) (NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this, L_5, L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:503>
		ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* L_7 = ___0_parent;
		__this->___parent = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_7);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:504>
		return;
	}
}
// Method Definition Index: 80977
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zip_Run_mE23D6EF0218FB77D5D7587C09F2BE03E19900B9D_gshared (Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	RuntimeObject* V_3 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:508>
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_0 = (ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*)(ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*)SZArrayNew(ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var, (uint32_t)4);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_1 = L_0;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___q1;
		NullCheck(L_1);
		ArrayElementTypeCheck (L_1, L_2);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_2);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_3 = L_1;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q2;
		NullCheck(L_3);
		ArrayElementTypeCheck (L_3, L_4);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_4);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_5 = L_3;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_6);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_7 = L_5;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q4;
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, L_8);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_8);
		NullCheck((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this);
		((  void (*) (NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*, ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 14)))((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this, L_7, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:509>
		ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* L_9 = __this->___parent;
		NullCheck(L_9);
		RuntimeObject* L_10 = L_9->___source1;
		RuntimeObject* L_11 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_12 = __this->___q1;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_13 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 16));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 17)))(L_13, L_11, (RuntimeObject*)__this, 0, L_12, il2cpp_rgctx_method(method->klass->rgctx_data, 17));
		NullCheck(L_10);
		RuntimeObject* L_14;
		L_14 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 15), L_10, (RuntimeObject*)L_13);
		V_0 = L_14;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:510>
		ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* L_15 = __this->___parent;
		NullCheck(L_15);
		RuntimeObject* L_16 = L_15->___source2;
		RuntimeObject* L_17 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_18 = __this->___q2;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_19 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 21));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 22)))(L_19, L_17, (RuntimeObject*)__this, 1, L_18, il2cpp_rgctx_method(method->klass->rgctx_data, 22));
		NullCheck(L_16);
		RuntimeObject* L_20;
		L_20 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 20), L_16, (RuntimeObject*)L_19);
		V_1 = L_20;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:511>
		ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* L_21 = __this->___parent;
		NullCheck(L_21);
		RuntimeObject* L_22 = L_21->___source3;
		RuntimeObject* L_23 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_24 = __this->___q3;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_25 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 26));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 27)))(L_25, L_23, (RuntimeObject*)__this, 2, L_24, il2cpp_rgctx_method(method->klass->rgctx_data, 27));
		NullCheck(L_22);
		RuntimeObject* L_26;
		L_26 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 25), L_22, (RuntimeObject*)L_25);
		V_2 = L_26;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:512>
		ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* L_27 = __this->___parent;
		NullCheck(L_27);
		RuntimeObject* L_28 = L_27->___source4;
		RuntimeObject* L_29 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_30 = __this->___q4;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_31 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 31));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 32)))(L_31, L_29, (RuntimeObject*)__this, 3, L_30, il2cpp_rgctx_method(method->klass->rgctx_data, 32));
		NullCheck(L_28);
		RuntimeObject* L_32;
		L_32 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 30), L_28, (RuntimeObject*)L_31);
		V_3 = L_32;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:514>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:515>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:516>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:517>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:518>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:519>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:520>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_33 = (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)SZArrayNew(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var, (uint32_t)5);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_34 = L_33;
		RuntimeObject* L_35 = V_0;
		NullCheck(L_34);
		ArrayElementTypeCheck (L_34, L_35);
		(L_34)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_35);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_36 = L_34;
		RuntimeObject* L_37 = V_1;
		NullCheck(L_36);
		ArrayElementTypeCheck (L_36, L_37);
		(L_36)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_37);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_38 = L_36;
		RuntimeObject* L_39 = V_2;
		NullCheck(L_38);
		ArrayElementTypeCheck (L_38, L_39);
		(L_38)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_39);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_40 = L_38;
		RuntimeObject* L_41 = V_3;
		NullCheck(L_40);
		ArrayElementTypeCheck (L_40, L_41);
		(L_40)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_41);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_42 = L_40;
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_43 = (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)il2cpp_codegen_object_new(Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		Action__ctor_mBDC7B0B4A3F583B64C2896F01BDED360772F67DC(L_43, (RuntimeObject*)__this, (intptr_t)((void*)il2cpp_rgctx_method(method->klass->rgctx_data, 35)), NULL);
		il2cpp_codegen_runtime_class_init_inline(Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		RuntimeObject* L_44;
		L_44 = Disposable_Create_m8FC5E161705A5AB1D0FD89067783648C9A6B1BF1(L_43, NULL);
		NullCheck(L_42);
		ArrayElementTypeCheck (L_42, L_44);
		(L_42)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_44);
		RuntimeObject* L_45;
		L_45 = StableCompositeDisposable_Create_mFC6500B00F009673E99112947958DF4058759242(L_42, NULL);
		return (RuntimeObject*)L_45;
	}
}
// Method Definition Index: 80978
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_GetResult_mA4CD9F66057E491430634FD362D6D401C5E8A06D_gshared (Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_tCC2EFAF18FBE9D06272C6CF7DA30575DD26E922C = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 46));
	const uint32_t SizeOf_T1_t6F9803295BA3EC4607E958288D660EEC1339C821 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 38));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T1_t6F9803295BA3EC4607E958288D660EEC1339C821);
	const uint32_t SizeOf_T2_t6018134346BAE2CC39184551475C3418C8C9B571 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 40));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T2_t6018134346BAE2CC39184551475C3418C8C9B571);
	const uint32_t SizeOf_T3_tCE9394636DF012695B52DA67285AE4B4F51A67ED = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 42));
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_T3_tCE9394636DF012695B52DA67285AE4B4F51A67ED);
	const uint32_t SizeOf_T4_t5DF4344513170C2C9F7255322ADD9F66B64CC9EE = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 44));
	const Il2CppFullySharedGenericAny L_9 = alloca(SizeOf_T4_t5DF4344513170C2C9F7255322ADD9F66B64CC9EE);
	const Il2CppFullySharedGenericAny L_10 = alloca(SizeOf_TR_tCC2EFAF18FBE9D06272C6CF7DA30575DD26E922C);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:525>
		ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* L_0 = __this->___parent;
		NullCheck(L_0);
		ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* L_1 = L_0->___resultSelector;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___q1;
		NullCheck(L_2);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 37)), il2cpp_rgctx_method(method->klass->rgctx_data, 37), L_2, (Il2CppFullySharedGenericAny*)L_3);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q2;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 39)), il2cpp_rgctx_method(method->klass->rgctx_data, 39), L_4, (Il2CppFullySharedGenericAny*)L_5);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 41)), il2cpp_rgctx_method(method->klass->rgctx_data, 41), L_6, (Il2CppFullySharedGenericAny*)L_7);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q4;
		NullCheck(L_8);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 43)), il2cpp_rgctx_method(method->klass->rgctx_data, 43), L_8, (Il2CppFullySharedGenericAny*)L_9);
		NullCheck(L_1);
		InvokerActionInvoker5< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 45)), il2cpp_rgctx_method(method->klass->rgctx_data, 45), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 38)) ? L_3: *(void**)L_3), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 40)) ? L_5: *(void**)L_5), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 42)) ? L_7: *(void**)L_7), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 44)) ? L_9: *(void**)L_9), (Il2CppFullySharedGenericAny*)L_10);
		il2cpp_codegen_memcpy(il2cppRetVal, L_10, SizeOf_TR_tCC2EFAF18FBE9D06272C6CF7DA30575DD26E922C);
		return;
	}
}
// Method Definition Index: 80979
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnNext_m815DCB95F14A9E6CB47E397D3C497B54C391B39A_gshared (Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_tCC2EFAF18FBE9D06272C6CF7DA30575DD26E922C = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 46));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TR_tCC2EFAF18FBE9D06272C6CF7DA30575DD26E922C);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:530>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 46)) ? ___0_value : &___0_value), SizeOf_TR_tCC2EFAF18FBE9D06272C6CF7DA30575DD26E922C);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 9), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 46)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:531>
		return;
	}
}
// Method Definition Index: 80980
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnError_mEBCCA3ACCC70A993688A05777A6A06B474697BE3_gshared (Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:536>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 51)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 51));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:536>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:535>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 9), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:535>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:537>
		return;
	}
}
// Method Definition Index: 80981
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnCompleted_m3038E0FF7571EEAD17347C3A2605F88A974EC3B2_gshared (Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:542>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 51)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 51));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:542>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:541>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 9), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:541>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:543>
		return;
	}
}
// Method Definition Index: 80982
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_U3CRunU3Eb__7_0_mE0B476389150D15863E5BB11AC1D044237907E46_gshared (Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:516>
		RuntimeObject* L_0 = __this->___gate;
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_003f:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_0048;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_0048:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:518>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q1;
			NullCheck(L_4);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 53)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 53));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:518>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_5 = __this->___q2;
			NullCheck(L_5);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 54)))(L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 54));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:518>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
			NullCheck(L_6);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 55)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 55));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:518>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_7 = __this->___q4;
			NullCheck(L_7);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 56)))(L_7, il2cpp_rgctx_method(method->klass->rgctx_data, 56));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:519>
			goto IL_0049;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0049:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:520>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80985
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip__ctor_m471D0840EEED70AA39AE41FAFDBD33A13D38CBBE_gshared (Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700* __this, ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:588>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:589>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_1 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 1));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))(L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		__this->___q1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q1), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:590>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 3));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 4)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 4));
		__this->___q2 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q2), (void*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:591>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_3 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 5));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))(L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		__this->___q3 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q3), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:592>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 7));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 8)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 8));
		__this->___q4 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q4), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:593>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_5 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 9));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))(L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		__this->___q5 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q5), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:596>
		RuntimeObject* L_6 = ___1_observer;
		RuntimeObject* L_7 = ___2_cancel;
		((  void (*) (NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this, L_6, L_7, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:598>
		ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* L_8 = ___0_parent;
		__this->___parent = L_8;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_8);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:599>
		return;
	}
}
// Method Definition Index: 80986
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zip_Run_mC84493C05D994B2B8066BE4B4CB3B2F9B5F47839_gshared (Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	RuntimeObject* V_3 = NULL;
	RuntimeObject* V_4 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:603>
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_0 = (ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*)(ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*)SZArrayNew(ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var, (uint32_t)5);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_1 = L_0;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___q1;
		NullCheck(L_1);
		ArrayElementTypeCheck (L_1, L_2);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_2);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_3 = L_1;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q2;
		NullCheck(L_3);
		ArrayElementTypeCheck (L_3, L_4);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_4);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_5 = L_3;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_6);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_7 = L_5;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q4;
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, L_8);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_8);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_9 = L_7;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_10 = __this->___q5;
		NullCheck(L_9);
		ArrayElementTypeCheck (L_9, L_10);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_10);
		NullCheck((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this);
		((  void (*) (NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*, ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 16)))((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 16));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:604>
		ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* L_11 = __this->___parent;
		NullCheck(L_11);
		RuntimeObject* L_12 = L_11->___source1;
		RuntimeObject* L_13 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_14 = __this->___q1;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_15 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 18));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 19)))(L_15, L_13, (RuntimeObject*)__this, 0, L_14, il2cpp_rgctx_method(method->klass->rgctx_data, 19));
		NullCheck(L_12);
		RuntimeObject* L_16;
		L_16 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 17), L_12, (RuntimeObject*)L_15);
		V_0 = L_16;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:605>
		ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* L_17 = __this->___parent;
		NullCheck(L_17);
		RuntimeObject* L_18 = L_17->___source2;
		RuntimeObject* L_19 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_20 = __this->___q2;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_21 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 23));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 24)))(L_21, L_19, (RuntimeObject*)__this, 1, L_20, il2cpp_rgctx_method(method->klass->rgctx_data, 24));
		NullCheck(L_18);
		RuntimeObject* L_22;
		L_22 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 22), L_18, (RuntimeObject*)L_21);
		V_1 = L_22;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:606>
		ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* L_23 = __this->___parent;
		NullCheck(L_23);
		RuntimeObject* L_24 = L_23->___source3;
		RuntimeObject* L_25 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_26 = __this->___q3;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_27 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 28));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 29)))(L_27, L_25, (RuntimeObject*)__this, 2, L_26, il2cpp_rgctx_method(method->klass->rgctx_data, 29));
		NullCheck(L_24);
		RuntimeObject* L_28;
		L_28 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 27), L_24, (RuntimeObject*)L_27);
		V_2 = L_28;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:607>
		ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* L_29 = __this->___parent;
		NullCheck(L_29);
		RuntimeObject* L_30 = L_29->___source4;
		RuntimeObject* L_31 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_32 = __this->___q4;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_33 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 33));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 34)))(L_33, L_31, (RuntimeObject*)__this, 3, L_32, il2cpp_rgctx_method(method->klass->rgctx_data, 34));
		NullCheck(L_30);
		RuntimeObject* L_34;
		L_34 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 32), L_30, (RuntimeObject*)L_33);
		V_3 = L_34;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:608>
		ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* L_35 = __this->___parent;
		NullCheck(L_35);
		RuntimeObject* L_36 = L_35->___source5;
		RuntimeObject* L_37 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_38 = __this->___q5;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_39 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 38));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 39)))(L_39, L_37, (RuntimeObject*)__this, 4, L_38, il2cpp_rgctx_method(method->klass->rgctx_data, 39));
		NullCheck(L_36);
		RuntimeObject* L_40;
		L_40 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 37), L_36, (RuntimeObject*)L_39);
		V_4 = L_40;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:610>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:611>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:612>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:613>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:614>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:615>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:616>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_41 = (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)SZArrayNew(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var, (uint32_t)6);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_42 = L_41;
		RuntimeObject* L_43 = V_0;
		NullCheck(L_42);
		ArrayElementTypeCheck (L_42, L_43);
		(L_42)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_43);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_44 = L_42;
		RuntimeObject* L_45 = V_1;
		NullCheck(L_44);
		ArrayElementTypeCheck (L_44, L_45);
		(L_44)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_45);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_46 = L_44;
		RuntimeObject* L_47 = V_2;
		NullCheck(L_46);
		ArrayElementTypeCheck (L_46, L_47);
		(L_46)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_47);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_48 = L_46;
		RuntimeObject* L_49 = V_3;
		NullCheck(L_48);
		ArrayElementTypeCheck (L_48, L_49);
		(L_48)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_49);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_50 = L_48;
		RuntimeObject* L_51 = V_4;
		NullCheck(L_50);
		ArrayElementTypeCheck (L_50, L_51);
		(L_50)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_51);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_52 = L_50;
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_53 = (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)il2cpp_codegen_object_new(Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		Action__ctor_mBDC7B0B4A3F583B64C2896F01BDED360772F67DC(L_53, (RuntimeObject*)__this, (intptr_t)((void*)il2cpp_rgctx_method(method->klass->rgctx_data, 42)), NULL);
		il2cpp_codegen_runtime_class_init_inline(Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		RuntimeObject* L_54;
		L_54 = Disposable_Create_m8FC5E161705A5AB1D0FD89067783648C9A6B1BF1(L_53, NULL);
		NullCheck(L_52);
		ArrayElementTypeCheck (L_52, L_54);
		(L_52)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject*)L_54);
		RuntimeObject* L_55;
		L_55 = StableCompositeDisposable_Create_mFC6500B00F009673E99112947958DF4058759242(L_52, NULL);
		return (RuntimeObject*)L_55;
	}
}
// Method Definition Index: 80987
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_GetResult_m1BAECEFD3696E9C467EA4B933F9F566D1AF10A4D_gshared (Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t30EB23C545F22C203635C126094FBA71E4B68118 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 55));
	const uint32_t SizeOf_T1_t629D7FD7BA136043F6C6661F162935C4F9C2C5AD = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 45));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T1_t629D7FD7BA136043F6C6661F162935C4F9C2C5AD);
	const uint32_t SizeOf_T2_tD00F5744E8C7CB8D04122B9008176D9DFE69F4A7 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 47));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T2_tD00F5744E8C7CB8D04122B9008176D9DFE69F4A7);
	const uint32_t SizeOf_T3_tCBA615CCBCAC4C4305DEB6D026EE1BA8C481F4A9 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 49));
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_T3_tCBA615CCBCAC4C4305DEB6D026EE1BA8C481F4A9);
	const uint32_t SizeOf_T4_t22CC08F11AAD0BE8EE74CC12732F294D6124CCAC = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 51));
	const Il2CppFullySharedGenericAny L_9 = alloca(SizeOf_T4_t22CC08F11AAD0BE8EE74CC12732F294D6124CCAC);
	const uint32_t SizeOf_T5_t0F22F8E7AFD3B88FE700E7C031CDDB0CB1A78F8B = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 53));
	const Il2CppFullySharedGenericAny L_11 = alloca(SizeOf_T5_t0F22F8E7AFD3B88FE700E7C031CDDB0CB1A78F8B);
	const Il2CppFullySharedGenericAny L_12 = alloca(SizeOf_TR_t30EB23C545F22C203635C126094FBA71E4B68118);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:621>
		ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* L_0 = __this->___parent;
		NullCheck(L_0);
		ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* L_1 = L_0->___resultSelector;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___q1;
		NullCheck(L_2);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 44)), il2cpp_rgctx_method(method->klass->rgctx_data, 44), L_2, (Il2CppFullySharedGenericAny*)L_3);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q2;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 46)), il2cpp_rgctx_method(method->klass->rgctx_data, 46), L_4, (Il2CppFullySharedGenericAny*)L_5);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 48)), il2cpp_rgctx_method(method->klass->rgctx_data, 48), L_6, (Il2CppFullySharedGenericAny*)L_7);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q4;
		NullCheck(L_8);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 50)), il2cpp_rgctx_method(method->klass->rgctx_data, 50), L_8, (Il2CppFullySharedGenericAny*)L_9);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_10 = __this->___q5;
		NullCheck(L_10);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 52)), il2cpp_rgctx_method(method->klass->rgctx_data, 52), L_10, (Il2CppFullySharedGenericAny*)L_11);
		NullCheck(L_1);
		InvokerActionInvoker6< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 54)), il2cpp_rgctx_method(method->klass->rgctx_data, 54), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 45)) ? L_3: *(void**)L_3), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 47)) ? L_5: *(void**)L_5), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 49)) ? L_7: *(void**)L_7), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 51)) ? L_9: *(void**)L_9), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 53)) ? L_11: *(void**)L_11), (Il2CppFullySharedGenericAny*)L_12);
		il2cpp_codegen_memcpy(il2cppRetVal, L_12, SizeOf_TR_t30EB23C545F22C203635C126094FBA71E4B68118);
		return;
	}
}
// Method Definition Index: 80988
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnNext_m4A7706190CD763F362224AAF850255A321A7A838_gshared (Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t30EB23C545F22C203635C126094FBA71E4B68118 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 55));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TR_t30EB23C545F22C203635C126094FBA71E4B68118);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:626>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 55)) ? ___0_value : &___0_value), SizeOf_TR_t30EB23C545F22C203635C126094FBA71E4B68118);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 11), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 55)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:627>
		return;
	}
}
// Method Definition Index: 80989
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnError_mDE1C0B00EECFA4EED90B454F6941F22581C2E925_gshared (Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:632>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 60)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 60));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:632>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:631>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 11), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:631>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:633>
		return;
	}
}
// Method Definition Index: 80990
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnCompleted_m55DE56DD5D97117CC744CE36E90EAF4B15AA720B_gshared (Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:638>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 60)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 60));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:638>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:637>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 11), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:637>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:639>
		return;
	}
}
// Method Definition Index: 80991
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_U3CRunU3Eb__8_0_m21E8E090A9C667AA82EA486C1016607E8625DE57_gshared (Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:612>
		RuntimeObject* L_0 = __this->___gate;
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_004a:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_0053;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_0053:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:614>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q1;
			NullCheck(L_4);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 62)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 62));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:614>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_5 = __this->___q2;
			NullCheck(L_5);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 63)))(L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 63));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:614>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
			NullCheck(L_6);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 64)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 64));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:614>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_7 = __this->___q4;
			NullCheck(L_7);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 65)))(L_7, il2cpp_rgctx_method(method->klass->rgctx_data, 65));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:614>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q5;
			NullCheck(L_8);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 66)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 66));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:615>
			goto IL_0054;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0054:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:616>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80994
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip__ctor_m6FD870DD5F8C41629D34A32B5DF434CE0AE67C46_gshared (Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49* __this, ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:688>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:689>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_1 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 1));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))(L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		__this->___q1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q1), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:690>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 3));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 4)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 4));
		__this->___q2 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q2), (void*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:691>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_3 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 5));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))(L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		__this->___q3 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q3), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:692>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 7));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 8)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 8));
		__this->___q4 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q4), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:693>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_5 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 9));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))(L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		__this->___q5 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q5), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:694>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 11));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		__this->___q6 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q6), (void*)L_6);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:697>
		RuntimeObject* L_7 = ___1_observer;
		RuntimeObject* L_8 = ___2_cancel;
		((  void (*) (NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 14)))((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this, L_7, L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:699>
		ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* L_9 = ___0_parent;
		__this->___parent = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_9);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:700>
		return;
	}
}
// Method Definition Index: 80995
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zip_Run_mE69AA20C369702DBC149772FBEBE4004711F1A87_gshared (Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	RuntimeObject* V_3 = NULL;
	RuntimeObject* V_4 = NULL;
	RuntimeObject* V_5 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:704>
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_0 = (ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*)(ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*)SZArrayNew(ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var, (uint32_t)6);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_1 = L_0;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___q1;
		NullCheck(L_1);
		ArrayElementTypeCheck (L_1, L_2);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_2);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_3 = L_1;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q2;
		NullCheck(L_3);
		ArrayElementTypeCheck (L_3, L_4);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_4);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_5 = L_3;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_6);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_7 = L_5;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q4;
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, L_8);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_8);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_9 = L_7;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_10 = __this->___q5;
		NullCheck(L_9);
		ArrayElementTypeCheck (L_9, L_10);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_10);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_11 = L_9;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_12 = __this->___q6;
		NullCheck(L_11);
		ArrayElementTypeCheck (L_11, L_12);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject*)L_12);
		NullCheck((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this);
		((  void (*) (NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*, ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 18)))((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this, L_11, il2cpp_rgctx_method(method->klass->rgctx_data, 18));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:705>
		ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* L_13 = __this->___parent;
		NullCheck(L_13);
		RuntimeObject* L_14 = L_13->___source1;
		RuntimeObject* L_15 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_16 = __this->___q1;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_17 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 20));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 21)))(L_17, L_15, (RuntimeObject*)__this, 0, L_16, il2cpp_rgctx_method(method->klass->rgctx_data, 21));
		NullCheck(L_14);
		RuntimeObject* L_18;
		L_18 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 19), L_14, (RuntimeObject*)L_17);
		V_0 = L_18;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:706>
		ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* L_19 = __this->___parent;
		NullCheck(L_19);
		RuntimeObject* L_20 = L_19->___source2;
		RuntimeObject* L_21 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_22 = __this->___q2;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_23 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 25));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 26)))(L_23, L_21, (RuntimeObject*)__this, 1, L_22, il2cpp_rgctx_method(method->klass->rgctx_data, 26));
		NullCheck(L_20);
		RuntimeObject* L_24;
		L_24 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 24), L_20, (RuntimeObject*)L_23);
		V_1 = L_24;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:707>
		ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* L_25 = __this->___parent;
		NullCheck(L_25);
		RuntimeObject* L_26 = L_25->___source3;
		RuntimeObject* L_27 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_28 = __this->___q3;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_29 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 30));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 31)))(L_29, L_27, (RuntimeObject*)__this, 2, L_28, il2cpp_rgctx_method(method->klass->rgctx_data, 31));
		NullCheck(L_26);
		RuntimeObject* L_30;
		L_30 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 29), L_26, (RuntimeObject*)L_29);
		V_2 = L_30;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:708>
		ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* L_31 = __this->___parent;
		NullCheck(L_31);
		RuntimeObject* L_32 = L_31->___source4;
		RuntimeObject* L_33 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_34 = __this->___q4;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_35 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 35));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 36)))(L_35, L_33, (RuntimeObject*)__this, 3, L_34, il2cpp_rgctx_method(method->klass->rgctx_data, 36));
		NullCheck(L_32);
		RuntimeObject* L_36;
		L_36 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 34), L_32, (RuntimeObject*)L_35);
		V_3 = L_36;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:709>
		ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* L_37 = __this->___parent;
		NullCheck(L_37);
		RuntimeObject* L_38 = L_37->___source5;
		RuntimeObject* L_39 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_40 = __this->___q5;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_41 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 40));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 41)))(L_41, L_39, (RuntimeObject*)__this, 4, L_40, il2cpp_rgctx_method(method->klass->rgctx_data, 41));
		NullCheck(L_38);
		RuntimeObject* L_42;
		L_42 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 39), L_38, (RuntimeObject*)L_41);
		V_4 = L_42;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:710>
		ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* L_43 = __this->___parent;
		NullCheck(L_43);
		RuntimeObject* L_44 = L_43->___source6;
		RuntimeObject* L_45 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_46 = __this->___q6;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_47 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 45));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 46)))(L_47, L_45, (RuntimeObject*)__this, 5, L_46, il2cpp_rgctx_method(method->klass->rgctx_data, 46));
		NullCheck(L_44);
		RuntimeObject* L_48;
		L_48 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 44), L_44, (RuntimeObject*)L_47);
		V_5 = L_48;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:712>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:713>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:714>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:715>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:716>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:717>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:718>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_49 = (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)SZArrayNew(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var, (uint32_t)7);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_50 = L_49;
		RuntimeObject* L_51 = V_0;
		NullCheck(L_50);
		ArrayElementTypeCheck (L_50, L_51);
		(L_50)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_51);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_52 = L_50;
		RuntimeObject* L_53 = V_1;
		NullCheck(L_52);
		ArrayElementTypeCheck (L_52, L_53);
		(L_52)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_53);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_54 = L_52;
		RuntimeObject* L_55 = V_2;
		NullCheck(L_54);
		ArrayElementTypeCheck (L_54, L_55);
		(L_54)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_55);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_56 = L_54;
		RuntimeObject* L_57 = V_3;
		NullCheck(L_56);
		ArrayElementTypeCheck (L_56, L_57);
		(L_56)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_57);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_58 = L_56;
		RuntimeObject* L_59 = V_4;
		NullCheck(L_58);
		ArrayElementTypeCheck (L_58, L_59);
		(L_58)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_59);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_60 = L_58;
		RuntimeObject* L_61 = V_5;
		NullCheck(L_60);
		ArrayElementTypeCheck (L_60, L_61);
		(L_60)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject*)L_61);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_62 = L_60;
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_63 = (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)il2cpp_codegen_object_new(Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		Action__ctor_mBDC7B0B4A3F583B64C2896F01BDED360772F67DC(L_63, (RuntimeObject*)__this, (intptr_t)((void*)il2cpp_rgctx_method(method->klass->rgctx_data, 49)), NULL);
		il2cpp_codegen_runtime_class_init_inline(Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		RuntimeObject* L_64;
		L_64 = Disposable_Create_m8FC5E161705A5AB1D0FD89067783648C9A6B1BF1(L_63, NULL);
		NullCheck(L_62);
		ArrayElementTypeCheck (L_62, L_64);
		(L_62)->SetAt(static_cast<il2cpp_array_size_t>(6), (RuntimeObject*)L_64);
		RuntimeObject* L_65;
		L_65 = StableCompositeDisposable_Create_mFC6500B00F009673E99112947958DF4058759242(L_62, NULL);
		return (RuntimeObject*)L_65;
	}
}
// Method Definition Index: 80996
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_GetResult_m3DB9BF29A4E453D22BA0B1E92E2E6B2B53629209_gshared (Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_tD6F023CC992AA2D4706ECBFB0A042CA7306CBA2F = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 64));
	const uint32_t SizeOf_T1_tA42A0D3D176666A701C2A9A308808017DA114B18 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 52));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T1_tA42A0D3D176666A701C2A9A308808017DA114B18);
	const uint32_t SizeOf_T2_t7034EF6F1D0D8629FBFDF2616863E6EBBCDAC0A6 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 54));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T2_t7034EF6F1D0D8629FBFDF2616863E6EBBCDAC0A6);
	const uint32_t SizeOf_T3_tC21F425E0EDBAEE6096EBE279B8598224C8CF33B = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 56));
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_T3_tC21F425E0EDBAEE6096EBE279B8598224C8CF33B);
	const uint32_t SizeOf_T4_t4E91BF30E60A6022457B47E61C438F01793C7EFA = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 58));
	const Il2CppFullySharedGenericAny L_9 = alloca(SizeOf_T4_t4E91BF30E60A6022457B47E61C438F01793C7EFA);
	const uint32_t SizeOf_T5_t72A95B6FBFE7165CE440D1EE34AA38DD9BE41FB5 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 60));
	const Il2CppFullySharedGenericAny L_11 = alloca(SizeOf_T5_t72A95B6FBFE7165CE440D1EE34AA38DD9BE41FB5);
	const uint32_t SizeOf_T6_t5525F06CC1728FBCFFC8F48BFBA2135B60EAA3CB = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 62));
	const Il2CppFullySharedGenericAny L_13 = alloca(SizeOf_T6_t5525F06CC1728FBCFFC8F48BFBA2135B60EAA3CB);
	const Il2CppFullySharedGenericAny L_14 = alloca(SizeOf_TR_tD6F023CC992AA2D4706ECBFB0A042CA7306CBA2F);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:723>
		ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* L_0 = __this->___parent;
		NullCheck(L_0);
		ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* L_1 = L_0->___resultSelector;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___q1;
		NullCheck(L_2);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 51)), il2cpp_rgctx_method(method->klass->rgctx_data, 51), L_2, (Il2CppFullySharedGenericAny*)L_3);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q2;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 53)), il2cpp_rgctx_method(method->klass->rgctx_data, 53), L_4, (Il2CppFullySharedGenericAny*)L_5);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 55)), il2cpp_rgctx_method(method->klass->rgctx_data, 55), L_6, (Il2CppFullySharedGenericAny*)L_7);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q4;
		NullCheck(L_8);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 57)), il2cpp_rgctx_method(method->klass->rgctx_data, 57), L_8, (Il2CppFullySharedGenericAny*)L_9);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_10 = __this->___q5;
		NullCheck(L_10);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 59)), il2cpp_rgctx_method(method->klass->rgctx_data, 59), L_10, (Il2CppFullySharedGenericAny*)L_11);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_12 = __this->___q6;
		NullCheck(L_12);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 61)), il2cpp_rgctx_method(method->klass->rgctx_data, 61), L_12, (Il2CppFullySharedGenericAny*)L_13);
		NullCheck(L_1);
		InvokerActionInvoker7< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 63)), il2cpp_rgctx_method(method->klass->rgctx_data, 63), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 52)) ? L_3: *(void**)L_3), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 54)) ? L_5: *(void**)L_5), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 56)) ? L_7: *(void**)L_7), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 58)) ? L_9: *(void**)L_9), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 60)) ? L_11: *(void**)L_11), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 62)) ? L_13: *(void**)L_13), (Il2CppFullySharedGenericAny*)L_14);
		il2cpp_codegen_memcpy(il2cppRetVal, L_14, SizeOf_TR_tD6F023CC992AA2D4706ECBFB0A042CA7306CBA2F);
		return;
	}
}
// Method Definition Index: 80997
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnNext_m4B267BB5DB8F39FC6017F0E6173202B9499E6C67_gshared (Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_tD6F023CC992AA2D4706ECBFB0A042CA7306CBA2F = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 64));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TR_tD6F023CC992AA2D4706ECBFB0A042CA7306CBA2F);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:728>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 64)) ? ___0_value : &___0_value), SizeOf_TR_tD6F023CC992AA2D4706ECBFB0A042CA7306CBA2F);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 13), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 64)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:729>
		return;
	}
}
// Method Definition Index: 80998
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnError_m29270C60AB0A898DB3572CA4D32FB4F59C28693E_gshared (Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:734>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 69)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 69));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:734>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:733>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 13), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:733>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:735>
		return;
	}
}
// Method Definition Index: 80999
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnCompleted_m72F2452B0C86FCC4E574F7589824A77998ADE34C_gshared (Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:740>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 69)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 69));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:740>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:739>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 13), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:739>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:741>
		return;
	}
}
// Method Definition Index: 81000
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_U3CRunU3Eb__9_0_m63C15A9D7428C52C461CB1141E7953C53571C598_gshared (Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:714>
		RuntimeObject* L_0 = __this->___gate;
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0055:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_005e;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_005e:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:716>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q1;
			NullCheck(L_4);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 71)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 71));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:716>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_5 = __this->___q2;
			NullCheck(L_5);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 72)))(L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 72));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:716>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
			NullCheck(L_6);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 73)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 73));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:716>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_7 = __this->___q4;
			NullCheck(L_7);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 74)))(L_7, il2cpp_rgctx_method(method->klass->rgctx_data, 74));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:716>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q5;
			NullCheck(L_8);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 75)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 75));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:716>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_9 = __this->___q6;
			NullCheck(L_9);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 76)))(L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 76));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:717>
			goto IL_005f;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_005f:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:718>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81003
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip__ctor_mD61387F93BB475B87D60D28BCA4B68D08238290A_gshared (Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3* __this, ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:794>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:795>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_1 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 1));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))(L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		__this->___q1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q1), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:796>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 3));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 4)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 4));
		__this->___q2 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q2), (void*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:797>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_3 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 5));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))(L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		__this->___q3 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q3), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:798>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 7));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 8)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 8));
		__this->___q4 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q4), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:799>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_5 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 9));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))(L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		__this->___q5 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q5), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:800>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 11));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		__this->___q6 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q6), (void*)L_6);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:801>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_7 = (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 13));
		((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 14)))(L_7, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		__this->___q7 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___q7), (void*)L_7);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:804>
		RuntimeObject* L_8 = ___1_observer;
		RuntimeObject* L_9 = ___2_cancel;
		((  void (*) (NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 16)))((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this, L_8, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 16));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:806>
		ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* L_10 = ___0_parent;
		__this->___parent = L_10;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_10);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:807>
		return;
	}
}
// Method Definition Index: 81004
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zip_Run_mD16D77F1FF5CA19949B07FFD192FE78CF2956975_gshared (Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	RuntimeObject* V_3 = NULL;
	RuntimeObject* V_4 = NULL;
	RuntimeObject* V_5 = NULL;
	RuntimeObject* V_6 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:811>
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_0 = (ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*)(ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*)SZArrayNew(ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273_il2cpp_TypeInfo_var, (uint32_t)7);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_1 = L_0;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___q1;
		NullCheck(L_1);
		ArrayElementTypeCheck (L_1, L_2);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_2);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_3 = L_1;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q2;
		NullCheck(L_3);
		ArrayElementTypeCheck (L_3, L_4);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_4);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_5 = L_3;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_6);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_7 = L_5;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q4;
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, L_8);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_8);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_9 = L_7;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_10 = __this->___q5;
		NullCheck(L_9);
		ArrayElementTypeCheck (L_9, L_10);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_10);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_11 = L_9;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_12 = __this->___q6;
		NullCheck(L_11);
		ArrayElementTypeCheck (L_11, L_12);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject*)L_12);
		ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273* L_13 = L_11;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_14 = __this->___q7;
		NullCheck(L_13);
		ArrayElementTypeCheck (L_13, L_14);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(6), (RuntimeObject*)L_14);
		NullCheck((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this);
		((  void (*) (NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*, ICollectionU5BU5D_t3C5AFBCC1FDF16A2BA036FA88D2B3387DBEAD273*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 20)))((NthZipObserverBase_1_t13433A138AC7C17AE88D820801D9869E3A1B9158*)__this, L_13, il2cpp_rgctx_method(method->klass->rgctx_data, 20));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:812>
		ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* L_15 = __this->___parent;
		NullCheck(L_15);
		RuntimeObject* L_16 = L_15->___source1;
		RuntimeObject* L_17 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_18 = __this->___q1;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_19 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 22));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 23)))(L_19, L_17, (RuntimeObject*)__this, 0, L_18, il2cpp_rgctx_method(method->klass->rgctx_data, 23));
		NullCheck(L_16);
		RuntimeObject* L_20;
		L_20 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 21), L_16, (RuntimeObject*)L_19);
		V_0 = L_20;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:813>
		ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* L_21 = __this->___parent;
		NullCheck(L_21);
		RuntimeObject* L_22 = L_21->___source2;
		RuntimeObject* L_23 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_24 = __this->___q2;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_25 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 27));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 28)))(L_25, L_23, (RuntimeObject*)__this, 1, L_24, il2cpp_rgctx_method(method->klass->rgctx_data, 28));
		NullCheck(L_22);
		RuntimeObject* L_26;
		L_26 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 26), L_22, (RuntimeObject*)L_25);
		V_1 = L_26;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:814>
		ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* L_27 = __this->___parent;
		NullCheck(L_27);
		RuntimeObject* L_28 = L_27->___source3;
		RuntimeObject* L_29 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_30 = __this->___q3;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_31 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 32));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 33)))(L_31, L_29, (RuntimeObject*)__this, 2, L_30, il2cpp_rgctx_method(method->klass->rgctx_data, 33));
		NullCheck(L_28);
		RuntimeObject* L_32;
		L_32 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 31), L_28, (RuntimeObject*)L_31);
		V_2 = L_32;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:815>
		ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* L_33 = __this->___parent;
		NullCheck(L_33);
		RuntimeObject* L_34 = L_33->___source4;
		RuntimeObject* L_35 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_36 = __this->___q4;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_37 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 37));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 38)))(L_37, L_35, (RuntimeObject*)__this, 3, L_36, il2cpp_rgctx_method(method->klass->rgctx_data, 38));
		NullCheck(L_34);
		RuntimeObject* L_38;
		L_38 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 36), L_34, (RuntimeObject*)L_37);
		V_3 = L_38;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:816>
		ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* L_39 = __this->___parent;
		NullCheck(L_39);
		RuntimeObject* L_40 = L_39->___source5;
		RuntimeObject* L_41 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_42 = __this->___q5;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_43 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 42));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 43)))(L_43, L_41, (RuntimeObject*)__this, 4, L_42, il2cpp_rgctx_method(method->klass->rgctx_data, 43));
		NullCheck(L_40);
		RuntimeObject* L_44;
		L_44 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 41), L_40, (RuntimeObject*)L_43);
		V_4 = L_44;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:817>
		ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* L_45 = __this->___parent;
		NullCheck(L_45);
		RuntimeObject* L_46 = L_45->___source6;
		RuntimeObject* L_47 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_48 = __this->___q6;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_49 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 47));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 48)))(L_49, L_47, (RuntimeObject*)__this, 5, L_48, il2cpp_rgctx_method(method->klass->rgctx_data, 48));
		NullCheck(L_46);
		RuntimeObject* L_50;
		L_50 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 46), L_46, (RuntimeObject*)L_49);
		V_5 = L_50;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:818>
		ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* L_51 = __this->___parent;
		NullCheck(L_51);
		RuntimeObject* L_52 = L_51->___source7;
		RuntimeObject* L_53 = __this->___gate;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_54 = __this->___q7;
		ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* L_55 = (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 52));
		((  void (*) (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802*, RuntimeObject*, RuntimeObject*, int32_t, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 53)))(L_55, L_53, (RuntimeObject*)__this, 6, L_54, il2cpp_rgctx_method(method->klass->rgctx_data, 53));
		NullCheck(L_52);
		RuntimeObject* L_56;
		L_56 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 51), L_52, (RuntimeObject*)L_55);
		V_6 = L_56;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:820>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:821>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:822>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:823>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:824>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:825>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:826>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_57 = (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)SZArrayNew(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var, (uint32_t)8);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_58 = L_57;
		RuntimeObject* L_59 = V_0;
		NullCheck(L_58);
		ArrayElementTypeCheck (L_58, L_59);
		(L_58)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_59);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_60 = L_58;
		RuntimeObject* L_61 = V_1;
		NullCheck(L_60);
		ArrayElementTypeCheck (L_60, L_61);
		(L_60)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_61);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_62 = L_60;
		RuntimeObject* L_63 = V_2;
		NullCheck(L_62);
		ArrayElementTypeCheck (L_62, L_63);
		(L_62)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_63);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_64 = L_62;
		RuntimeObject* L_65 = V_3;
		NullCheck(L_64);
		ArrayElementTypeCheck (L_64, L_65);
		(L_64)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_65);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_66 = L_64;
		RuntimeObject* L_67 = V_4;
		NullCheck(L_66);
		ArrayElementTypeCheck (L_66, L_67);
		(L_66)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_67);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_68 = L_66;
		RuntimeObject* L_69 = V_5;
		NullCheck(L_68);
		ArrayElementTypeCheck (L_68, L_69);
		(L_68)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject*)L_69);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_70 = L_68;
		RuntimeObject* L_71 = V_6;
		NullCheck(L_70);
		ArrayElementTypeCheck (L_70, L_71);
		(L_70)->SetAt(static_cast<il2cpp_array_size_t>(6), (RuntimeObject*)L_71);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_72 = L_70;
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_73 = (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)il2cpp_codegen_object_new(Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07_il2cpp_TypeInfo_var);
		Action__ctor_mBDC7B0B4A3F583B64C2896F01BDED360772F67DC(L_73, (RuntimeObject*)__this, (intptr_t)((void*)il2cpp_rgctx_method(method->klass->rgctx_data, 56)), NULL);
		il2cpp_codegen_runtime_class_init_inline(Disposable_t11429F449A26608E8CCE4F8CCF2DF161AD77B9D3_il2cpp_TypeInfo_var);
		RuntimeObject* L_74;
		L_74 = Disposable_Create_m8FC5E161705A5AB1D0FD89067783648C9A6B1BF1(L_73, NULL);
		NullCheck(L_72);
		ArrayElementTypeCheck (L_72, L_74);
		(L_72)->SetAt(static_cast<il2cpp_array_size_t>(7), (RuntimeObject*)L_74);
		RuntimeObject* L_75;
		L_75 = StableCompositeDisposable_Create_mFC6500B00F009673E99112947958DF4058759242(L_72, NULL);
		return (RuntimeObject*)L_75;
	}
}
// Method Definition Index: 81005
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_GetResult_m836F3DF8AC1E9F94232F357E92D6E4D6D3B93DCB_gshared (Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t456B6DC979C152D04B4550FBAD7F9CA7635BFC4E = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 73));
	const uint32_t SizeOf_T1_t4734C379321AEB8E57AC4EB57DDC71F1A5CEC5E0 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 59));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T1_t4734C379321AEB8E57AC4EB57DDC71F1A5CEC5E0);
	const uint32_t SizeOf_T2_t3A494B5B8BDA74801BF442DF89378578D8B71E65 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 61));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T2_t3A494B5B8BDA74801BF442DF89378578D8B71E65);
	const uint32_t SizeOf_T3_t64E3C7BE0AC134C94E2B59075F1E43D86BBCFFE4 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 63));
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_T3_t64E3C7BE0AC134C94E2B59075F1E43D86BBCFFE4);
	const uint32_t SizeOf_T4_tA27470B0912839903DE172F5C37BBED6812BC661 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 65));
	const Il2CppFullySharedGenericAny L_9 = alloca(SizeOf_T4_tA27470B0912839903DE172F5C37BBED6812BC661);
	const uint32_t SizeOf_T5_t31F283B259B71506E181168B87C21650B66F5CD4 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 67));
	const Il2CppFullySharedGenericAny L_11 = alloca(SizeOf_T5_t31F283B259B71506E181168B87C21650B66F5CD4);
	const uint32_t SizeOf_T6_tFE82157822AA835F25133CE2C9E9188327E8D836 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 69));
	const Il2CppFullySharedGenericAny L_13 = alloca(SizeOf_T6_tFE82157822AA835F25133CE2C9E9188327E8D836);
	const uint32_t SizeOf_T7_tEBE39BB933C01FCDD3E33CA5742611DC61B6FF6D = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 71));
	const Il2CppFullySharedGenericAny L_15 = alloca(SizeOf_T7_tEBE39BB933C01FCDD3E33CA5742611DC61B6FF6D);
	const Il2CppFullySharedGenericAny L_16 = alloca(SizeOf_TR_t456B6DC979C152D04B4550FBAD7F9CA7635BFC4E);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:831>
		ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* L_0 = __this->___parent;
		NullCheck(L_0);
		ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* L_1 = L_0->___resultSelector;
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_2 = __this->___q1;
		NullCheck(L_2);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 58)), il2cpp_rgctx_method(method->klass->rgctx_data, 58), L_2, (Il2CppFullySharedGenericAny*)L_3);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q2;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 60)), il2cpp_rgctx_method(method->klass->rgctx_data, 60), L_4, (Il2CppFullySharedGenericAny*)L_5);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 62)), il2cpp_rgctx_method(method->klass->rgctx_data, 62), L_6, (Il2CppFullySharedGenericAny*)L_7);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q4;
		NullCheck(L_8);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 64)), il2cpp_rgctx_method(method->klass->rgctx_data, 64), L_8, (Il2CppFullySharedGenericAny*)L_9);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_10 = __this->___q5;
		NullCheck(L_10);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 66)), il2cpp_rgctx_method(method->klass->rgctx_data, 66), L_10, (Il2CppFullySharedGenericAny*)L_11);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_12 = __this->___q6;
		NullCheck(L_12);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 68)), il2cpp_rgctx_method(method->klass->rgctx_data, 68), L_12, (Il2CppFullySharedGenericAny*)L_13);
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_14 = __this->___q7;
		NullCheck(L_14);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 70)), il2cpp_rgctx_method(method->klass->rgctx_data, 70), L_14, (Il2CppFullySharedGenericAny*)L_15);
		NullCheck(L_1);
		InvokerActionInvoker8< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 72)), il2cpp_rgctx_method(method->klass->rgctx_data, 72), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 59)) ? L_3: *(void**)L_3), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 61)) ? L_5: *(void**)L_5), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 63)) ? L_7: *(void**)L_7), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 65)) ? L_9: *(void**)L_9), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 67)) ? L_11: *(void**)L_11), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 69)) ? L_13: *(void**)L_13), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 71)) ? L_15: *(void**)L_15), (Il2CppFullySharedGenericAny*)L_16);
		il2cpp_codegen_memcpy(il2cppRetVal, L_16, SizeOf_TR_t456B6DC979C152D04B4550FBAD7F9CA7635BFC4E);
		return;
	}
}
// Method Definition Index: 81006
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnNext_m87A961F0A04161FEA4B0D206808850F3E3180D4F_gshared (Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t456B6DC979C152D04B4550FBAD7F9CA7635BFC4E = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 73));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TR_t456B6DC979C152D04B4550FBAD7F9CA7635BFC4E);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:836>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 73)) ? ___0_value : &___0_value), SizeOf_TR_t456B6DC979C152D04B4550FBAD7F9CA7635BFC4E);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 15), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 73)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:837>
		return;
	}
}
// Method Definition Index: 81007
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnError_m54155AF5F1914A62D35433503A162C4DCC812AC8_gshared (Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:842>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 78)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 78));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:842>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:841>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 15), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:841>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:843>
		return;
	}
}
// Method Definition Index: 81008
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_OnCompleted_m51B74156FF728749AFE8EF895B158276A21F7AFC_gshared (Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:848>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 78)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 78));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:848>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:847>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 15), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:847>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:849>
		return;
	}
}
// Method Definition Index: 81009
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zip_U3CRunU3Eb__10_0_m14DBB6F5F5F35224290B02FE622EA2BE4D0CD2F1_gshared (Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:822>
		RuntimeObject* L_0 = __this->___gate;
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0060:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_0069;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_0069:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:824>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___q1;
			NullCheck(L_4);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 80)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 80));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:824>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_5 = __this->___q2;
			NullCheck(L_5);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 81)))(L_5, il2cpp_rgctx_method(method->klass->rgctx_data, 81));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:824>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_6 = __this->___q3;
			NullCheck(L_6);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 82)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 82));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:824>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_7 = __this->___q4;
			NullCheck(L_7);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 83)))(L_7, il2cpp_rgctx_method(method->klass->rgctx_data, 83));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:824>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_8 = __this->___q5;
			NullCheck(L_8);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 84)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 84));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:824>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_9 = __this->___q6;
			NullCheck(L_9);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 85)))(L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 85));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:824>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_10 = __this->___q7;
			NullCheck(L_10);
			((  void (*) (Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 86)))(L_10, il2cpp_rgctx_method(method->klass->rgctx_data, 86));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:825>
			goto IL_006a;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_006a:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:826>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_Multicast(ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* currentDelegate = reinterpret_cast<ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenStaticInvoker(ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker4< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_ClosedStaticInvoker(ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker5< RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_ClosedInstInvoker(ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker4< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenInstInvoker(ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InvokerActionInvoker3< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenVirtualInvoker(ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	VirtualActionInvoker3Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenInterfaceInvoker(ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InterfaceActionInvoker3Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenGenericVirtualInvoker(ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericVirtualActionInvoker3Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenGenericInterfaceInvoker(ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericInterfaceActionInvoker3Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
// Method Definition Index: 80915
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_4__ctor_mE0FC3DDFF2FD2F40E1D172F0775DD366A0C93309_gshared (ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 3;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenGenericInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenGenericVirtualInvoker;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenVirtualInvoker;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_OpenInstInvoker;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_Multicast;
}
// Method Definition Index: 80916
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_4_Invoke_m57458DB9C82C14AF88BE1E9BF567A675C5CDA490_gshared (ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 80917
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipFunc_4_BeginInvoke_m16AF4E38D358DDD7CC7BAA2F917241505885653D_gshared (ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___3_callback, RuntimeObject* ___4_object, const RuntimeMethod* method) 
{
	void *__d_args[4] = {0};
	RuntimeClass* ___0_arg1_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 0));
	__d_args[0] = (il2cpp_codegen_class_is_value_type(___0_arg1_klass) ? Box(___0_arg1_klass, ___0_arg1) : (void*)___0_arg1);
	RuntimeClass* ___1_arg2_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 1));
	__d_args[1] = (il2cpp_codegen_class_is_value_type(___1_arg2_klass) ? Box(___1_arg2_klass, ___1_arg2) : (void*)___1_arg2);
	RuntimeClass* ___2_arg3_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 2));
	__d_args[2] = (il2cpp_codegen_class_is_value_type(___2_arg3_klass) ? Box(___2_arg3_klass, ___2_arg3) : (void*)___2_arg3);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___3_callback, (RuntimeObject*)___4_object);
}
// Method Definition Index: 80918
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_4_EndInvoke_m29871F52C640B8B15E6D5E67711C2CC3D0F9981D_gshared (ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* __this, RuntimeObject* ___0_result, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
	RuntimeClass* returnType = il2cpp_codegen_class_from_type(il2cpp_codegen_method_return_type((MethodInfo*)__this->___method));
	uint32_t returnTypeSize = il2cpp_codegen_sizeof(returnType);
	void* unboxStorage = alloca(returnTypeSize);
	void* unboxed = UnBox_Any((RuntimeObject*)__result, returnType, unboxStorage);
	il2cpp_codegen_memcpy(il2cppRetVal, unboxed, returnTypeSize);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_Multicast(ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* currentDelegate = reinterpret_cast<ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenStaticInvoker(ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker5< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_ClosedStaticInvoker(ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker6< RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_ClosedInstInvoker(ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker5< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenInstInvoker(ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InvokerActionInvoker4< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenVirtualInvoker(ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	VirtualActionInvoker4Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenInterfaceInvoker(ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InterfaceActionInvoker4Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenGenericVirtualInvoker(ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericVirtualActionInvoker4Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenGenericInterfaceInvoker(ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericInterfaceActionInvoker4Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
// Method Definition Index: 80919
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_5__ctor_m5316746895B7D7AB34E1BB0AAB213E4A716175F9_gshared (ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 4;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 3;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenGenericInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenGenericVirtualInvoker;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenVirtualInvoker;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_OpenInstInvoker;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_Multicast;
}
// Method Definition Index: 80920
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_5_Invoke_mB974496A265618B891A2EF3E521BB2750A631213_gshared (ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 80921
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipFunc_5_BeginInvoke_m1CA25ADECF1586077BF9148591C585C8719DAC10_gshared (ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___4_callback, RuntimeObject* ___5_object, const RuntimeMethod* method) 
{
	void *__d_args[5] = {0};
	RuntimeClass* ___0_arg1_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 0));
	__d_args[0] = (il2cpp_codegen_class_is_value_type(___0_arg1_klass) ? Box(___0_arg1_klass, ___0_arg1) : (void*)___0_arg1);
	RuntimeClass* ___1_arg2_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 1));
	__d_args[1] = (il2cpp_codegen_class_is_value_type(___1_arg2_klass) ? Box(___1_arg2_klass, ___1_arg2) : (void*)___1_arg2);
	RuntimeClass* ___2_arg3_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 2));
	__d_args[2] = (il2cpp_codegen_class_is_value_type(___2_arg3_klass) ? Box(___2_arg3_klass, ___2_arg3) : (void*)___2_arg3);
	RuntimeClass* ___3_arg4_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 3));
	__d_args[3] = (il2cpp_codegen_class_is_value_type(___3_arg4_klass) ? Box(___3_arg4_klass, ___3_arg4) : (void*)___3_arg4);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___4_callback, (RuntimeObject*)___5_object);
}
// Method Definition Index: 80922
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_5_EndInvoke_mC366484D82B8D1E89A30D102AD4B427A1D8DBDB2_gshared (ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* __this, RuntimeObject* ___0_result, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
	RuntimeClass* returnType = il2cpp_codegen_class_from_type(il2cpp_codegen_method_return_type((MethodInfo*)__this->___method));
	uint32_t returnTypeSize = il2cpp_codegen_sizeof(returnType);
	void* unboxStorage = alloca(returnTypeSize);
	void* unboxed = UnBox_Any((RuntimeObject*)__result, returnType, unboxStorage);
	il2cpp_codegen_memcpy(il2cppRetVal, unboxed, returnTypeSize);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_Multicast(ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* currentDelegate = reinterpret_cast<ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenStaticInvoker(ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker6< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_ClosedStaticInvoker(ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker7< RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_ClosedInstInvoker(ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker6< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenInstInvoker(ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InvokerActionInvoker5< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenVirtualInvoker(ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	VirtualActionInvoker5Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenInterfaceInvoker(ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InterfaceActionInvoker5Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenGenericVirtualInvoker(ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericVirtualActionInvoker5Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenGenericInterfaceInvoker(ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericInterfaceActionInvoker5Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
// Method Definition Index: 80923
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_6__ctor_mD2C72EA7AA9BFD08A3E738B3320BB36073F28087_gshared (ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 5;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 4;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenGenericInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenGenericVirtualInvoker;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenVirtualInvoker;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_OpenInstInvoker;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_Multicast;
}
// Method Definition Index: 80924
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_6_Invoke_m09B40B7B937EC5D4F76F00FA5EBA63378AC3F2A7_gshared (ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 80925
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipFunc_6_BeginInvoke_m71205B21A09B0166AB6D89EFBFBD23D8249B44D8_gshared (ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___5_callback, RuntimeObject* ___6_object, const RuntimeMethod* method) 
{
	void *__d_args[6] = {0};
	RuntimeClass* ___0_arg1_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 0));
	__d_args[0] = (il2cpp_codegen_class_is_value_type(___0_arg1_klass) ? Box(___0_arg1_klass, ___0_arg1) : (void*)___0_arg1);
	RuntimeClass* ___1_arg2_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 1));
	__d_args[1] = (il2cpp_codegen_class_is_value_type(___1_arg2_klass) ? Box(___1_arg2_klass, ___1_arg2) : (void*)___1_arg2);
	RuntimeClass* ___2_arg3_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 2));
	__d_args[2] = (il2cpp_codegen_class_is_value_type(___2_arg3_klass) ? Box(___2_arg3_klass, ___2_arg3) : (void*)___2_arg3);
	RuntimeClass* ___3_arg4_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 3));
	__d_args[3] = (il2cpp_codegen_class_is_value_type(___3_arg4_klass) ? Box(___3_arg4_klass, ___3_arg4) : (void*)___3_arg4);
	RuntimeClass* ___4_arg5_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 4));
	__d_args[4] = (il2cpp_codegen_class_is_value_type(___4_arg5_klass) ? Box(___4_arg5_klass, ___4_arg5) : (void*)___4_arg5);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___5_callback, (RuntimeObject*)___6_object);
}
// Method Definition Index: 80926
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_6_EndInvoke_mD10DEA08C543DB4BFECD2E4C64E821F87798338A_gshared (ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* __this, RuntimeObject* ___0_result, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
	RuntimeClass* returnType = il2cpp_codegen_class_from_type(il2cpp_codegen_method_return_type((MethodInfo*)__this->___method));
	uint32_t returnTypeSize = il2cpp_codegen_sizeof(returnType);
	void* unboxStorage = alloca(returnTypeSize);
	void* unboxed = UnBox_Any((RuntimeObject*)__result, returnType, unboxStorage);
	il2cpp_codegen_memcpy(il2cppRetVal, unboxed, returnTypeSize);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_Multicast(ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* currentDelegate = reinterpret_cast<ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenStaticInvoker(ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker7< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_ClosedStaticInvoker(ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker8< RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_ClosedInstInvoker(ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker7< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenInstInvoker(ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InvokerActionInvoker6< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenVirtualInvoker(ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	VirtualActionInvoker6Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenInterfaceInvoker(ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InterfaceActionInvoker6Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenGenericVirtualInvoker(ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericVirtualActionInvoker6Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenGenericInterfaceInvoker(ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericInterfaceActionInvoker6Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
// Method Definition Index: 80927
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_7__ctor_mD4D4561941A80E2A8A618A0AD8BC60E61D6EFFC5_gshared (ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 6;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 5;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenGenericInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenGenericVirtualInvoker;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenVirtualInvoker;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_OpenInstInvoker;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_Multicast;
}
// Method Definition Index: 80928
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_7_Invoke_m5304C0B400866D6F38EF1C24F2518935E3B6F181_gshared (ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 80929
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipFunc_7_BeginInvoke_m75EF348B036BD8C10311C43B91CBD042E67A4B6D_gshared (ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___6_callback, RuntimeObject* ___7_object, const RuntimeMethod* method) 
{
	void *__d_args[7] = {0};
	RuntimeClass* ___0_arg1_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 0));
	__d_args[0] = (il2cpp_codegen_class_is_value_type(___0_arg1_klass) ? Box(___0_arg1_klass, ___0_arg1) : (void*)___0_arg1);
	RuntimeClass* ___1_arg2_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 1));
	__d_args[1] = (il2cpp_codegen_class_is_value_type(___1_arg2_klass) ? Box(___1_arg2_klass, ___1_arg2) : (void*)___1_arg2);
	RuntimeClass* ___2_arg3_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 2));
	__d_args[2] = (il2cpp_codegen_class_is_value_type(___2_arg3_klass) ? Box(___2_arg3_klass, ___2_arg3) : (void*)___2_arg3);
	RuntimeClass* ___3_arg4_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 3));
	__d_args[3] = (il2cpp_codegen_class_is_value_type(___3_arg4_klass) ? Box(___3_arg4_klass, ___3_arg4) : (void*)___3_arg4);
	RuntimeClass* ___4_arg5_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 4));
	__d_args[4] = (il2cpp_codegen_class_is_value_type(___4_arg5_klass) ? Box(___4_arg5_klass, ___4_arg5) : (void*)___4_arg5);
	RuntimeClass* ___5_arg6_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 5));
	__d_args[5] = (il2cpp_codegen_class_is_value_type(___5_arg6_klass) ? Box(___5_arg6_klass, ___5_arg6) : (void*)___5_arg6);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___6_callback, (RuntimeObject*)___7_object);
}
// Method Definition Index: 80930
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_7_EndInvoke_mC99C005EBB31F71B11326A9165BA1581A297AC10_gshared (ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* __this, RuntimeObject* ___0_result, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
	RuntimeClass* returnType = il2cpp_codegen_class_from_type(il2cpp_codegen_method_return_type((MethodInfo*)__this->___method));
	uint32_t returnTypeSize = il2cpp_codegen_sizeof(returnType);
	void* unboxStorage = alloca(returnTypeSize);
	void* unboxed = UnBox_Any((RuntimeObject*)__result, returnType, unboxStorage);
	il2cpp_codegen_memcpy(il2cppRetVal, unboxed, returnTypeSize);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_Multicast(ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* currentDelegate = reinterpret_cast<ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenStaticInvoker(ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker8< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_ClosedStaticInvoker(ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker9< RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_ClosedInstInvoker(ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker8< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenInstInvoker(ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InvokerActionInvoker7< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenVirtualInvoker(ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	VirtualActionInvoker7Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenInterfaceInvoker(ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InterfaceActionInvoker7Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenGenericVirtualInvoker(ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericVirtualActionInvoker7Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenGenericInterfaceInvoker(ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericInterfaceActionInvoker7Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
// Method Definition Index: 80931
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_8__ctor_m157500CB7798DD36E3270F988CA108634AD8F605_gshared (ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 7;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 6;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenGenericInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenGenericVirtualInvoker;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenVirtualInvoker;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_OpenInstInvoker;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_Multicast;
}
// Method Definition Index: 80932
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_8_Invoke_m25C276EF82BEABA6085838765D24F52A00007A5C_gshared (ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 80933
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipFunc_8_BeginInvoke_mCD6A1FD4C3DBB3B03E6F88AAF863A47F6BF53377_gshared (ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___7_callback, RuntimeObject* ___8_object, const RuntimeMethod* method) 
{
	void *__d_args[8] = {0};
	RuntimeClass* ___0_arg1_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 0));
	__d_args[0] = (il2cpp_codegen_class_is_value_type(___0_arg1_klass) ? Box(___0_arg1_klass, ___0_arg1) : (void*)___0_arg1);
	RuntimeClass* ___1_arg2_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 1));
	__d_args[1] = (il2cpp_codegen_class_is_value_type(___1_arg2_klass) ? Box(___1_arg2_klass, ___1_arg2) : (void*)___1_arg2);
	RuntimeClass* ___2_arg3_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 2));
	__d_args[2] = (il2cpp_codegen_class_is_value_type(___2_arg3_klass) ? Box(___2_arg3_klass, ___2_arg3) : (void*)___2_arg3);
	RuntimeClass* ___3_arg4_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 3));
	__d_args[3] = (il2cpp_codegen_class_is_value_type(___3_arg4_klass) ? Box(___3_arg4_klass, ___3_arg4) : (void*)___3_arg4);
	RuntimeClass* ___4_arg5_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 4));
	__d_args[4] = (il2cpp_codegen_class_is_value_type(___4_arg5_klass) ? Box(___4_arg5_klass, ___4_arg5) : (void*)___4_arg5);
	RuntimeClass* ___5_arg6_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 5));
	__d_args[5] = (il2cpp_codegen_class_is_value_type(___5_arg6_klass) ? Box(___5_arg6_klass, ___5_arg6) : (void*)___5_arg6);
	RuntimeClass* ___6_arg7_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 6));
	__d_args[6] = (il2cpp_codegen_class_is_value_type(___6_arg7_klass) ? Box(___6_arg7_klass, ___6_arg7) : (void*)___6_arg7);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___7_callback, (RuntimeObject*)___8_object);
}
// Method Definition Index: 80934
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFunc_8_EndInvoke_m3C975D1C9431B81AB73A24C510E957087888C46E_gshared (ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* __this, RuntimeObject* ___0_result, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
	RuntimeClass* returnType = il2cpp_codegen_class_from_type(il2cpp_codegen_method_return_type((MethodInfo*)__this->___method));
	uint32_t returnTypeSize = il2cpp_codegen_sizeof(returnType);
	void* unboxStorage = alloca(returnTypeSize);
	void* unboxed = UnBox_Any((RuntimeObject*)__result, returnType, unboxStorage);
	il2cpp_codegen_memcpy(il2cppRetVal, unboxed, returnTypeSize);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81061
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest__ctor_m4C58ACD687E268FDC0B81157FE5917DF0DD9D407_gshared (ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* __this, ZipLatestObservable_1_t2A28BD239FCAB16DD9001B4A9F9D9F151D9CD77C* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:211>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:218>
		RuntimeObject* L_1 = ___1_observer;
		RuntimeObject* L_2 = ___2_cancel;
		((  void (*) (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, L_1, L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:220>
		ZipLatestObservable_1_t2A28BD239FCAB16DD9001B4A9F9D9F151D9CD77C* L_3 = ___0_parent;
		__this->___parent = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:221>
		return;
	}
}
// Method Definition Index: 81062
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatest_Run_m10038D117C5646EB169C4D79173B611AD2F070B1_gshared (ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* V_0 = NULL;
	int32_t V_1 = 0;
	RuntimeObject* V_2 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:225>
		ZipLatestObservable_1_t2A28BD239FCAB16DD9001B4A9F9D9F151D9CD77C* L_0 = __this->___parent;
		NullCheck(L_0);
		IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035* L_1 = L_0->___sources;
		NullCheck(L_1);
		__this->___length = ((int32_t)(((RuntimeArray*)L_1)->max_length));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:226>
		int32_t L_2 = __this->___length;
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_3 = (__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC*)(__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC*)SZArrayNew(il2cpp_rgctx_data(method->klass->rgctx_data, 6), (uint32_t)L_2);
		__this->___values = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___values), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:227>
		int32_t L_4 = __this->___length;
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_5 = (BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4*)(BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4*)SZArrayNew(BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4_il2cpp_TypeInfo_var, (uint32_t)L_4);
		__this->___isStarted = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___isStarted), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:228>
		int32_t L_6 = __this->___length;
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_7 = (BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4*)(BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4*)SZArrayNew(BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4_il2cpp_TypeInfo_var, (uint32_t)L_6);
		__this->___isCompleted = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___isCompleted), (void*)L_7);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:230>
		int32_t L_8 = __this->___length;
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_9 = (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)SZArrayNew(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var, (uint32_t)L_8);
		V_0 = L_9;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:231>
		V_1 = 0;
		goto IL_0078;
	}

IL_0056:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:233>
		ZipLatestObservable_1_t2A28BD239FCAB16DD9001B4A9F9D9F151D9CD77C* L_10 = __this->___parent;
		NullCheck(L_10);
		IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035* L_11 = L_10->___sources;
		int32_t L_12 = V_1;
		NullCheck(L_11);
		int32_t L_13 = L_12;
		RuntimeObject* L_14 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_13));
		V_2 = L_14;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:234>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_15 = V_0;
		int32_t L_16 = V_1;
		RuntimeObject* L_17 = V_2;
		int32_t L_18 = V_1;
		ZipLatestObserver_t4BE85AB314360398FC0402187EBCBE96BFF04C75* L_19 = (ZipLatestObserver_t4BE85AB314360398FC0402187EBCBE96BFF04C75*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 8));
		((  void (*) (ZipLatestObserver_t4BE85AB314360398FC0402187EBCBE96BFF04C75*, ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_19, __this, L_18, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		NullCheck(L_17);
		RuntimeObject* L_20;
		L_20 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 10), L_17, (RuntimeObject*)L_19);
		NullCheck(L_15);
		ArrayElementTypeCheck (L_15, L_20);
		(L_15)->SetAt(static_cast<il2cpp_array_size_t>(L_16), (RuntimeObject*)L_20);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:231>
		int32_t L_21 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_0078:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:231>
		int32_t L_22 = V_1;
		int32_t L_23 = __this->___length;
		if ((((int32_t)L_22) < ((int32_t)L_23)))
		{
			goto IL_0056;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:237>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_24 = V_0;
		RuntimeObject* L_25;
		L_25 = StableCompositeDisposable_CreateUnsafe_m61E9E95FD914CF4A0EB267CBE46D63AB1066FD08(L_24, NULL);
		return (RuntimeObject*)L_25;
	}
}
// Method Definition Index: 81063
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_Publish_mDA9BBF5EE4572416485E011725227797E9BB01FF_gshared (ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* __this, int32_t ___0_index, const RuntimeMethod* method) 
{
	bool V_0 = false;
	bool V_1 = false;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:243>
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_0 = __this->___isStarted;
		int32_t L_1 = ___0_index;
		NullCheck(L_0);
		(L_0)->SetAt(static_cast<il2cpp_array_size_t>(L_1), (bool)1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:245>
		V_0 = (bool)0;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:246>
		V_1 = (bool)1;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:247>
		V_2 = 0;
		goto IL_0033;
	}

IL_0011:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:249>
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_2 = __this->___isStarted;
		int32_t L_3 = V_2;
		NullCheck(L_2);
		int32_t L_4 = L_3;
		uint8_t L_5 = (uint8_t)(L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		if (L_5)
		{
			goto IL_001f;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:251>
		V_1 = (bool)0;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:252>
		goto IL_003c;
	}

IL_001f:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:254>
		int32_t L_6 = V_2;
		int32_t L_7 = ___0_index;
		if ((((int32_t)L_6) == ((int32_t)L_7)))
		{
			goto IL_002f;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:255>
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_8 = __this->___isCompleted;
		int32_t L_9 = V_2;
		NullCheck(L_8);
		int32_t L_10 = L_9;
		uint8_t L_11 = (uint8_t)(L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		if (!L_11)
		{
			goto IL_002f;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:255>
		V_0 = (bool)1;
	}

IL_002f:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:247>
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_0033:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:247>
		int32_t L_13 = V_2;
		int32_t L_14 = __this->___length;
		if ((((int32_t)L_13) < ((int32_t)L_14)))
		{
			goto IL_0011;
		}
	}

IL_003c:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:258>
		bool L_15 = V_1;
		if (!L_15)
		{
			goto IL_007d;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:260>
		__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_16 = __this->___values;
		List_1_tDBA89B0E21BAC58CFBD3C1F76E4668E3B562761A* L_17 = (List_1_tDBA89B0E21BAC58CFBD3C1F76E4668E3B562761A*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 13));
		((  void (*) (List_1_tDBA89B0E21BAC58CFBD3C1F76E4668E3B562761A*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 14)))(L_17, (RuntimeObject*)L_16, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this);
		VirtualActionInvoker1Invoker< RuntimeObject* >::Invoke(8, (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, (RuntimeObject*)L_17);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:261>
		bool L_18 = V_0;
		if (!L_18)
		{
			goto IL_006a;
		}
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0062:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:264>
				NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this);
				((  void (*) (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 21)))((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 21));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:264>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:263>
			RuntimeObject* L_19 = ((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_19);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_19);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:263>
			goto IL_0069;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0069:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:265>
		return;
	}

IL_006a:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:269>
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_20 = __this->___isStarted;
		int32_t L_21 = __this->___length;
		Array_Clear_m50BAA3751899858B097D3FF2ED31F284703FE5CB((RuntimeArray*)L_20, 0, L_21, NULL);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:270>
		return;
	}

IL_007d:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:275>
		V_3 = 0;
		goto IL_00b4;
	}

IL_0081:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:277>
		int32_t L_22 = V_3;
		int32_t L_23 = ___0_index;
		if ((((int32_t)L_22) == ((int32_t)L_23)))
		{
			goto IL_00b0;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:278>
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_24 = __this->___isCompleted;
		int32_t L_25 = V_3;
		NullCheck(L_24);
		int32_t L_26 = L_25;
		uint8_t L_27 = (uint8_t)(L_24)->GetAt(static_cast<il2cpp_array_size_t>(L_26));
		if (!L_27)
		{
			goto IL_00b0;
		}
	}
	{
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_28 = __this->___isStarted;
		int32_t L_29 = V_3;
		NullCheck(L_28);
		int32_t L_30 = L_29;
		uint8_t L_31 = (uint8_t)(L_28)->GetAt(static_cast<il2cpp_array_size_t>(L_30));
		if (L_31)
		{
			goto IL_00b0;
		}
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_00a8:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:281>
				NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this);
				((  void (*) (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 21)))((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 21));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:281>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:280>
			RuntimeObject* L_32 = ((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_32);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_32);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:280>
			goto IL_00af;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_00af:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:282>
		return;
	}

IL_00b0:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:275>
		int32_t L_33 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_33, 1));
	}

IL_00b4:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:275>
		int32_t L_34 = V_3;
		int32_t L_35 = __this->___length;
		if ((((int32_t)L_34) < ((int32_t)L_35)))
		{
			goto IL_0081;
		}
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:286>
		return;
	}
}
// Method Definition Index: 81064
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnNext_m5F915EEE220B3290819F84D156E08D2556927557_gshared (ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* __this, RuntimeObject* ___0_value, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:290>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		RuntimeObject* L_1 = ___0_value;
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:291>
		return;
	}
}
// Method Definition Index: 81065
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnError_m3B2C05BA797B49CB7917CD507C7529132487ED71_gshared (ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:296>
				NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this);
				((  void (*) (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 21)))((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 21));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:296>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:295>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:295>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:297>
		return;
	}
}
// Method Definition Index: 81066
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnCompleted_m7D8F0FAC90A20F9C49F6A4E94AB94CD672384FCF_gshared (ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:302>
				NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this);
				((  void (*) (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 21)))((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 21));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:302>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:301>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:301>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:303>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81045
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest__ctor_m132055837EFD493D3F0B910A42FA6F87B90C6EF4_gshared (ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527* __this, ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091* ___0_parent, RuntimeObject* ___1_observer, RuntimeObject* ___2_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:37>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		il2cpp_codegen_write_instance_field_data<RuntimeObject*>(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),1), L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:47>
		RuntimeObject* L_1 = ___1_observer;
		RuntimeObject* L_2 = ___2_cancel;
		((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, L_1, L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:49>
		ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091* L_3 = ___0_parent;
		il2cpp_codegen_write_instance_field_data<ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091*>(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0), L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:50>
		return;
	}
}
// Method Definition Index: 81046
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatest_Run_m50E843D3C07EB1424996983A1471DCA8EC4BE2FC_gshared (ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:54>
		ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091* L_0 = *(ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0));
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->___left;
		LeftObserver_tB7E464B198322A284E0266355C4DACB5A3A3B66E* L_2 = (LeftObserver_tB7E464B198322A284E0266355C4DACB5A3A3B66E*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 6));
		((  void (*) (LeftObserver_tB7E464B198322A284E0266355C4DACB5A3A3B66E*, ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_2, __this, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		NullCheck(L_1);
		RuntimeObject* L_3;
		L_3 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 5), L_1, (RuntimeObject*)L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:55>
		ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091* L_4 = *(ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0));
		NullCheck(L_4);
		RuntimeObject* L_5 = L_4->___right;
		RightObserver_tCD0571F80F305840348F458D5771051BDE215447* L_6 = (RightObserver_tCD0571F80F305840348F458D5771051BDE215447*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 11));
		((  void (*) (RightObserver_tCD0571F80F305840348F458D5771051BDE215447*, ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))(L_6, __this, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		NullCheck(L_5);
		RuntimeObject* L_7;
		L_7 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 10), L_5, (RuntimeObject*)L_6);
		V_0 = L_7;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:57>
		RuntimeObject* L_8 = V_0;
		RuntimeObject* L_9;
		L_9 = StableCompositeDisposable_Create_m5D5EAA49FB4EC4511BB1750B44E0836762530FC3(L_3, L_8, NULL);
		return (RuntimeObject*)L_9;
	}
}
// Method Definition Index: 81047
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_Publish_m6CB949B9BE39FCD5516E22F007744E519A6E4838_gshared (ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527* __this, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TResult_tF2D5B2AE8E89EDC311339C32C3807526743F985E = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 23));
	const uint32_t SizeOf_TLeft_t98BB634D36728CA239C70588CF3AD9C93C795629 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 20));
	const uint32_t SizeOf_TRight_tBEA6B0350965062AAC6F1F327E7D848D184B2D98 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 21));
	const Il2CppFullySharedGenericAny L_9 = alloca(SizeOf_TLeft_t98BB634D36728CA239C70588CF3AD9C93C795629);
	const Il2CppFullySharedGenericAny L_10 = alloca(SizeOf_TRight_tBEA6B0350965062AAC6F1F327E7D848D184B2D98);
	const Il2CppFullySharedGenericAny L_11 = alloca(SizeOf_TResult_tF2D5B2AE8E89EDC311339C32C3807526743F985E);
	const Il2CppFullySharedGenericAny L_15 = L_11;
	Il2CppFullySharedGenericAny V_0 = alloca(SizeOf_TResult_tF2D5B2AE8E89EDC311339C32C3807526743F985E);
	memset(V_0, 0, SizeOf_TResult_tF2D5B2AE8E89EDC311339C32C3807526743F985E);
	Exception_t* V_1 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:63>
		bool L_0 = *(bool*)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),4));
		if (!L_0)
		{
			goto IL_0010;
		}
	}
	{
		bool L_1 = *(bool*)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),3));
		if (!L_1)
		{
			goto IL_0020;
		}
	}

IL_0010:
	{
		bool L_2 = *(bool*)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),7));
		if (!L_2)
		{
			goto IL_0038;
		}
	}
	{
		bool L_3 = *(bool*)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),6));
		if (L_3)
		{
			goto IL_0038;
		}
	}

IL_0020:
	{
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0030:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:66>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 18)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 18));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:66>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:65>
			RuntimeObject* L_4 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_4);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_4);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:65>
			goto IL_0037;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0037:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:67>
		return;
	}

IL_0038:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:69>
		bool L_5 = *(bool*)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),3));
		if (!L_5)
		{
			goto IL_0048;
		}
	}
	{
		bool L_6 = *(bool*)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),6));
		if (L_6)
		{
			goto IL_0049;
		}
	}

IL_0048:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:71>
		return;
	}

IL_0049:
	{
	}
	try
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:77>
		ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091* L_7 = *(ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0));
		NullCheck(L_7);
		Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* L_8 = L_7->___selector;
		il2cpp_codegen_memcpy(L_9, il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),2)), SizeOf_TLeft_t98BB634D36728CA239C70588CF3AD9C93C795629);
		il2cpp_codegen_memcpy(L_10, il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),5)), SizeOf_TRight_tBEA6B0350965062AAC6F1F327E7D848D184B2D98);
		NullCheck(L_8);
		InvokerActionInvoker3< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 22)), il2cpp_rgctx_method(method->klass->rgctx_data, 22), L_8, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 20)) ? L_9: *(void**)L_9), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 21)) ? L_10: *(void**)L_10), (Il2CppFullySharedGenericAny*)L_11);
		il2cpp_codegen_memcpy(V_0, L_11, SizeOf_TResult_tF2D5B2AE8E89EDC311339C32C3807526743F985E);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:78>
		goto IL_0083;
	}
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0069;
		}
		throw e;
	}

CATCH_0069:
	{
		{
			Exception_t* L_12 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));;
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:79>
			V_1 = L_12;
		}
		{
			auto __finallyBlock = il2cpp::utils::Finally([&]
			{

FINALLY_007a:
				{
					//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:82>
					NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
					((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 18)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 18));
					//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:82>
					return;
				}
			});
			try
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:81>
				RuntimeObject* L_13 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
				il2cpp_codegen_memory_barrier();
				Exception_t* L_14 = V_1;
				NullCheck(L_13);
				InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_13, L_14);
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:81>
				goto IL_0081;
			}
			catch(Il2CppExceptionWrapper& e)
			{
				__finallyBlock.StoreException(e.ex);
			}
		}

IL_0081:
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:83>
			IL2CPP_POP_ACTIVE_EXCEPTION(Exception_t*);
			goto IL_00c0;
		}
	}

IL_0083:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:86>
		il2cpp_codegen_memcpy(L_15, V_0, SizeOf_TResult_tF2D5B2AE8E89EDC311339C32C3807526743F985E);
		NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
		VirtualActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(8, (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 23)) ? L_15: *(void**)L_15));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:87>
		il2cpp_codegen_write_instance_field_data<bool>(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),3), (bool)0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:88>
		il2cpp_codegen_write_instance_field_data<bool>(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),6), (bool)0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:90>
		bool L_16 = *(bool*)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),4));
		if (L_16)
		{
			goto IL_00a8;
		}
	}
	{
		bool L_17 = *(bool*)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),7));
		if (!L_17)
		{
			goto IL_00c0;
		}
	}

IL_00a8:
	{
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_00b8:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:93>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 18)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 18));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:93>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:92>
			RuntimeObject* L_18 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_18);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_18);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:92>
			goto IL_00bf;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_00bf:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:94>
		return;
	}

IL_00c0:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:96>
		return;
	}
}
// Method Definition Index: 81048
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnNext_m5542751E610E1EBBF99E568A92C9451A916310FF_gshared (ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TResult_tF2D5B2AE8E89EDC311339C32C3807526743F985E = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 23));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TResult_tF2D5B2AE8E89EDC311339C32C3807526743F985E);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:100>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 23)) ? ___0_value : &___0_value), SizeOf_TResult_tF2D5B2AE8E89EDC311339C32C3807526743F985E);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 23)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:101>
		return;
	}
}
// Method Definition Index: 81049
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnError_m9C6FCDBEE4DC73812564222FA5BCEE5B365000B3_gshared (ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:106>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 18)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 18));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:106>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:105>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:105>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:107>
		return;
	}
}
// Method Definition Index: 81050
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnCompleted_mDBAA411E63A10928631E403666D52355C39586D0_gshared (ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:112>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 18)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 18));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:112>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:111>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:111>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:113>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81073
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest__ctor_m4FC10AE5D383A509D99B84873384FAD79F8C802F_gshared (ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957* __this, int32_t ___0_length, ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* ___1_parent, RuntimeObject* ___2_observer, RuntimeObject* ___3_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:394>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:400>
		int32_t L_1 = ___0_length;
		RuntimeObject* L_2 = ___2_observer;
		RuntimeObject* L_3 = ___3_cancel;
		((  void (*) (NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857*, int32_t, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))((NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857*)__this, L_1, L_2, L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:402>
		ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* L_4 = ___1_parent;
		__this->___parent = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:403>
		return;
	}
}
// Method Definition Index: 81074
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatest_Run_m969CC2E5A41E7B1EA4F6B6A8AF35158CD91F89BB_gshared (ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:407>
		RuntimeObject* L_0 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_1 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 6));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_1, L_0, (RuntimeObject*)__this, 0, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		__this->___c1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c1), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:408>
		RuntimeObject* L_2 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_3 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 8));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_3, L_2, (RuntimeObject*)__this, 1, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		__this->___c2 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c2), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:409>
		RuntimeObject* L_4 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_5 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 10));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_5, L_4, (RuntimeObject*)__this, 2, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		__this->___c3 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c3), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:411>
		ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* L_6 = __this->___parent;
		NullCheck(L_6);
		RuntimeObject* L_7 = L_6->___source1;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_8 = __this->___c1;
		NullCheck(L_7);
		RuntimeObject* L_9;
		L_9 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 12), L_7, (RuntimeObject*)L_8);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:412>
		ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* L_10 = __this->___parent;
		NullCheck(L_10);
		RuntimeObject* L_11 = L_10->___source2;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_12 = __this->___c2;
		NullCheck(L_11);
		RuntimeObject* L_13;
		L_13 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 15), L_11, (RuntimeObject*)L_12);
		V_0 = L_13;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:413>
		ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* L_14 = __this->___parent;
		NullCheck(L_14);
		RuntimeObject* L_15 = L_14->___source3;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_16 = __this->___c3;
		NullCheck(L_15);
		RuntimeObject* L_17;
		L_17 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 18), L_15, (RuntimeObject*)L_16);
		V_1 = L_17;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:415>
		RuntimeObject* L_18 = V_0;
		RuntimeObject* L_19 = V_1;
		RuntimeObject* L_20;
		L_20 = StableCompositeDisposable_Create_m69159E99C420E2BBE360CC54400E67127D36E724(L_9, L_18, L_19, NULL);
		return (RuntimeObject*)L_20;
	}
}
// Method Definition Index: 81075
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_GetResult_mF9161DD9D83B75CBB635337E660D12BDAC1EF79C_gshared (ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t5B37D8E9647D8484BC430D200F6AC70091EDCF3F = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 29));
	const uint32_t SizeOf_T1_tB80E0E41DA9B6D2EFEA0EB7C6BDF5862659FB7A1 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 23));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T1_tB80E0E41DA9B6D2EFEA0EB7C6BDF5862659FB7A1);
	const uint32_t SizeOf_T2_tAFA0F8BC68C2A0DFFD0DC32FC40119315546D51A = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 25));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T2_tAFA0F8BC68C2A0DFFD0DC32FC40119315546D51A);
	const uint32_t SizeOf_T3_tF1EEC2C076EFCCDF192B1BEBC72A4E9FA431847D = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 27));
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_T3_tF1EEC2C076EFCCDF192B1BEBC72A4E9FA431847D);
	const Il2CppFullySharedGenericAny L_8 = alloca(SizeOf_TR_t5B37D8E9647D8484BC430D200F6AC70091EDCF3F);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:420>
		ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* L_0 = __this->___parent;
		NullCheck(L_0);
		ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* L_1 = L_0->___resultSelector;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_2 = __this->___c1;
		NullCheck(L_2);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 22)), il2cpp_rgctx_method(method->klass->rgctx_data, 22), L_2, (Il2CppFullySharedGenericAny*)L_3);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_4 = __this->___c2;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 24)), il2cpp_rgctx_method(method->klass->rgctx_data, 24), L_4, (Il2CppFullySharedGenericAny*)L_5);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_6 = __this->___c3;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 26)), il2cpp_rgctx_method(method->klass->rgctx_data, 26), L_6, (Il2CppFullySharedGenericAny*)L_7);
		NullCheck(L_1);
		InvokerActionInvoker4< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 28)), il2cpp_rgctx_method(method->klass->rgctx_data, 28), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 23)) ? L_3: *(void**)L_3), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 25)) ? L_5: *(void**)L_5), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 27)) ? L_7: *(void**)L_7), (Il2CppFullySharedGenericAny*)L_8);
		il2cpp_codegen_memcpy(il2cppRetVal, L_8, SizeOf_TR_t5B37D8E9647D8484BC430D200F6AC70091EDCF3F);
		return;
	}
}
// Method Definition Index: 81076
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnNext_m790A3F7F781B29CFC77441E8CA731133EBF5AEAD_gshared (ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t5B37D8E9647D8484BC430D200F6AC70091EDCF3F = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 29));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TR_t5B37D8E9647D8484BC430D200F6AC70091EDCF3F);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:425>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 29)) ? ___0_value : &___0_value), SizeOf_TR_t5B37D8E9647D8484BC430D200F6AC70091EDCF3F);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 29)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:426>
		return;
	}
}
// Method Definition Index: 81077
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnError_mF3FE52FE533135D4F66D9BC42A7AA1CFAB981C8E_gshared (ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:431>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 34)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 34));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:431>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:430>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:430>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:432>
		return;
	}
}
// Method Definition Index: 81078
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnCompleted_m0712E528DEC8F9BC197EA261261DC2926CC29808_gshared (ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:437>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 34)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 34));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:437>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:436>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:436>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:438>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81081
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest__ctor_mC4C2562100A9463B45084C374068DA2541932C9B_gshared (ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D* __this, int32_t ___0_length, ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* ___1_parent, RuntimeObject* ___2_observer, RuntimeObject* ___3_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:479>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:486>
		int32_t L_1 = ___0_length;
		RuntimeObject* L_2 = ___2_observer;
		RuntimeObject* L_3 = ___3_cancel;
		((  void (*) (NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857*, int32_t, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))((NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857*)__this, L_1, L_2, L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:488>
		ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* L_4 = ___1_parent;
		__this->___parent = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:489>
		return;
	}
}
// Method Definition Index: 81082
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatest_Run_m6FBAE92EB0DF19572611670A3EE7149379D6FC8C_gshared (ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:493>
		RuntimeObject* L_0 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_1 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 6));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_1, L_0, (RuntimeObject*)__this, 0, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		__this->___c1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c1), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:494>
		RuntimeObject* L_2 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_3 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 8));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_3, L_2, (RuntimeObject*)__this, 1, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		__this->___c2 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c2), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:495>
		RuntimeObject* L_4 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_5 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 10));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_5, L_4, (RuntimeObject*)__this, 2, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		__this->___c3 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c3), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:496>
		RuntimeObject* L_6 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_7 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 12));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 13)))(L_7, L_6, (RuntimeObject*)__this, 3, il2cpp_rgctx_method(method->klass->rgctx_data, 13));
		__this->___c4 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c4), (void*)L_7);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:498>
		ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* L_8 = __this->___parent;
		NullCheck(L_8);
		RuntimeObject* L_9 = L_8->___source1;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_10 = __this->___c1;
		NullCheck(L_9);
		RuntimeObject* L_11;
		L_11 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 14), L_9, (RuntimeObject*)L_10);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:499>
		ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* L_12 = __this->___parent;
		NullCheck(L_12);
		RuntimeObject* L_13 = L_12->___source2;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_14 = __this->___c2;
		NullCheck(L_13);
		RuntimeObject* L_15;
		L_15 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 17), L_13, (RuntimeObject*)L_14);
		V_0 = L_15;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:500>
		ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* L_16 = __this->___parent;
		NullCheck(L_16);
		RuntimeObject* L_17 = L_16->___source3;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_18 = __this->___c3;
		NullCheck(L_17);
		RuntimeObject* L_19;
		L_19 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 20), L_17, (RuntimeObject*)L_18);
		V_1 = L_19;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:501>
		ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* L_20 = __this->___parent;
		NullCheck(L_20);
		RuntimeObject* L_21 = L_20->___source4;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_22 = __this->___c4;
		NullCheck(L_21);
		RuntimeObject* L_23;
		L_23 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 23), L_21, (RuntimeObject*)L_22);
		V_2 = L_23;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:503>
		RuntimeObject* L_24 = V_0;
		RuntimeObject* L_25 = V_1;
		RuntimeObject* L_26 = V_2;
		RuntimeObject* L_27;
		L_27 = StableCompositeDisposable_Create_mEF2811969D2F81FD06130ED8A4A48D26E42F9B94(L_11, L_24, L_25, L_26, NULL);
		return (RuntimeObject*)L_27;
	}
}
// Method Definition Index: 81083
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_GetResult_m7C3C0E3F33062E24227B0D127D94B0AF8B771B30_gshared (ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t590E082F0585394F0FFE4B429D353EF1DC3B5F33 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 36));
	const uint32_t SizeOf_T1_tD0BC57540214E1BA98A0411B3291398166739270 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 28));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T1_tD0BC57540214E1BA98A0411B3291398166739270);
	const uint32_t SizeOf_T2_t06695090DD8EA4D34356BCA43EB090609AA35815 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 30));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T2_t06695090DD8EA4D34356BCA43EB090609AA35815);
	const uint32_t SizeOf_T3_t3AFDB6E4BCC7AD03BFCBCE1D57516FB4FEE92184 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 32));
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_T3_t3AFDB6E4BCC7AD03BFCBCE1D57516FB4FEE92184);
	const uint32_t SizeOf_T4_t9CBA4E8E8A94B6E36D16D20F84D4804CBB1AE97B = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 34));
	const Il2CppFullySharedGenericAny L_9 = alloca(SizeOf_T4_t9CBA4E8E8A94B6E36D16D20F84D4804CBB1AE97B);
	const Il2CppFullySharedGenericAny L_10 = alloca(SizeOf_TR_t590E082F0585394F0FFE4B429D353EF1DC3B5F33);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:508>
		ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* L_0 = __this->___parent;
		NullCheck(L_0);
		ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* L_1 = L_0->___resultSelector;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_2 = __this->___c1;
		NullCheck(L_2);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 27)), il2cpp_rgctx_method(method->klass->rgctx_data, 27), L_2, (Il2CppFullySharedGenericAny*)L_3);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_4 = __this->___c2;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 29)), il2cpp_rgctx_method(method->klass->rgctx_data, 29), L_4, (Il2CppFullySharedGenericAny*)L_5);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_6 = __this->___c3;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 31)), il2cpp_rgctx_method(method->klass->rgctx_data, 31), L_6, (Il2CppFullySharedGenericAny*)L_7);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_8 = __this->___c4;
		NullCheck(L_8);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 33)), il2cpp_rgctx_method(method->klass->rgctx_data, 33), L_8, (Il2CppFullySharedGenericAny*)L_9);
		NullCheck(L_1);
		InvokerActionInvoker5< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 35)), il2cpp_rgctx_method(method->klass->rgctx_data, 35), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 28)) ? L_3: *(void**)L_3), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 30)) ? L_5: *(void**)L_5), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 32)) ? L_7: *(void**)L_7), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 34)) ? L_9: *(void**)L_9), (Il2CppFullySharedGenericAny*)L_10);
		il2cpp_codegen_memcpy(il2cppRetVal, L_10, SizeOf_TR_t590E082F0585394F0FFE4B429D353EF1DC3B5F33);
		return;
	}
}
// Method Definition Index: 81084
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnNext_m9287A717744CFE49EED08A1A5C44ADE222592F1C_gshared (ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t590E082F0585394F0FFE4B429D353EF1DC3B5F33 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 36));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TR_t590E082F0585394F0FFE4B429D353EF1DC3B5F33);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:513>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 36)) ? ___0_value : &___0_value), SizeOf_TR_t590E082F0585394F0FFE4B429D353EF1DC3B5F33);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 36)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:514>
		return;
	}
}
// Method Definition Index: 81085
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnError_mF22D69F3CB91287380585E24B541DD5D1C71A2B5_gshared (ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:519>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 41)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 41));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:519>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:518>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:518>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:520>
		return;
	}
}
// Method Definition Index: 81086
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnCompleted_mFF798A15A426A2B06D662B656C17EFEF2A3482AC_gshared (ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:525>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 41)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 41));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:525>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:524>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:524>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:526>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81089
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest__ctor_m7E70071FE496F45237EA0CA45FD35087D433BFFA_gshared (ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2* __this, int32_t ___0_length, ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* ___1_parent, RuntimeObject* ___2_observer, RuntimeObject* ___3_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:571>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:579>
		int32_t L_1 = ___0_length;
		RuntimeObject* L_2 = ___2_observer;
		RuntimeObject* L_3 = ___3_cancel;
		((  void (*) (NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857*, int32_t, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))((NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857*)__this, L_1, L_2, L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:581>
		ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* L_4 = ___1_parent;
		__this->___parent = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:582>
		return;
	}
}
// Method Definition Index: 81090
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatest_Run_m2F92D595A3EFB6F4F22B0028EF5131B2F28A7CCA_gshared (ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	RuntimeObject* V_3 = NULL;
	RuntimeObject* V_4 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:586>
		RuntimeObject* L_0 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_1 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 6));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_1, L_0, (RuntimeObject*)__this, 0, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		__this->___c1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c1), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:587>
		RuntimeObject* L_2 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_3 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 8));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_3, L_2, (RuntimeObject*)__this, 1, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		__this->___c2 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c2), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:588>
		RuntimeObject* L_4 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_5 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 10));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_5, L_4, (RuntimeObject*)__this, 2, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		__this->___c3 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c3), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:589>
		RuntimeObject* L_6 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_7 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 12));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 13)))(L_7, L_6, (RuntimeObject*)__this, 3, il2cpp_rgctx_method(method->klass->rgctx_data, 13));
		__this->___c4 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c4), (void*)L_7);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:590>
		RuntimeObject* L_8 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_9 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 14));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 15)))(L_9, L_8, (RuntimeObject*)__this, 4, il2cpp_rgctx_method(method->klass->rgctx_data, 15));
		__this->___c5 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c5), (void*)L_9);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:592>
		ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* L_10 = __this->___parent;
		NullCheck(L_10);
		RuntimeObject* L_11 = L_10->___source1;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_12 = __this->___c1;
		NullCheck(L_11);
		RuntimeObject* L_13;
		L_13 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 16), L_11, (RuntimeObject*)L_12);
		V_0 = L_13;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:593>
		ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* L_14 = __this->___parent;
		NullCheck(L_14);
		RuntimeObject* L_15 = L_14->___source2;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_16 = __this->___c2;
		NullCheck(L_15);
		RuntimeObject* L_17;
		L_17 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 19), L_15, (RuntimeObject*)L_16);
		V_1 = L_17;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:594>
		ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* L_18 = __this->___parent;
		NullCheck(L_18);
		RuntimeObject* L_19 = L_18->___source3;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_20 = __this->___c3;
		NullCheck(L_19);
		RuntimeObject* L_21;
		L_21 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 22), L_19, (RuntimeObject*)L_20);
		V_2 = L_21;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:595>
		ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* L_22 = __this->___parent;
		NullCheck(L_22);
		RuntimeObject* L_23 = L_22->___source4;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_24 = __this->___c4;
		NullCheck(L_23);
		RuntimeObject* L_25;
		L_25 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 25), L_23, (RuntimeObject*)L_24);
		V_3 = L_25;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:596>
		ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* L_26 = __this->___parent;
		NullCheck(L_26);
		RuntimeObject* L_27 = L_26->___source5;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_28 = __this->___c5;
		NullCheck(L_27);
		RuntimeObject* L_29;
		L_29 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 28), L_27, (RuntimeObject*)L_28);
		V_4 = L_29;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:598>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_30 = (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)SZArrayNew(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var, (uint32_t)5);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_31 = L_30;
		RuntimeObject* L_32 = V_0;
		NullCheck(L_31);
		ArrayElementTypeCheck (L_31, L_32);
		(L_31)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_32);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_33 = L_31;
		RuntimeObject* L_34 = V_1;
		NullCheck(L_33);
		ArrayElementTypeCheck (L_33, L_34);
		(L_33)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_34);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_35 = L_33;
		RuntimeObject* L_36 = V_2;
		NullCheck(L_35);
		ArrayElementTypeCheck (L_35, L_36);
		(L_35)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_36);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_37 = L_35;
		RuntimeObject* L_38 = V_3;
		NullCheck(L_37);
		ArrayElementTypeCheck (L_37, L_38);
		(L_37)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_38);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_39 = L_37;
		RuntimeObject* L_40 = V_4;
		NullCheck(L_39);
		ArrayElementTypeCheck (L_39, L_40);
		(L_39)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_40);
		RuntimeObject* L_41;
		L_41 = StableCompositeDisposable_Create_mFC6500B00F009673E99112947958DF4058759242(L_39, NULL);
		return (RuntimeObject*)L_41;
	}
}
// Method Definition Index: 81091
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_GetResult_m45A2AE83056F5FC72638347DBC9D7042C17A0A17_gshared (ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t30FD969AA0A2A2B632D3CEF7FC3D94F81C759682 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 43));
	const uint32_t SizeOf_T1_t1B0B5C9EB86DFDF9109EA3263F4D3147AE2903B4 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 33));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T1_t1B0B5C9EB86DFDF9109EA3263F4D3147AE2903B4);
	const uint32_t SizeOf_T2_tBA2779A4AB2AAAE2BFF7D87DBA61F4BE08440718 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 35));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T2_tBA2779A4AB2AAAE2BFF7D87DBA61F4BE08440718);
	const uint32_t SizeOf_T3_t84BA771846D080B83DC336C2FD486F815BBCD54E = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 37));
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_T3_t84BA771846D080B83DC336C2FD486F815BBCD54E);
	const uint32_t SizeOf_T4_t93D60DA93E52215F9CD3763CCAF24640588BFAEA = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 39));
	const Il2CppFullySharedGenericAny L_9 = alloca(SizeOf_T4_t93D60DA93E52215F9CD3763CCAF24640588BFAEA);
	const uint32_t SizeOf_T5_tE30F6358E6F6960C5D005F26E5226BE1A88FD104 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 41));
	const Il2CppFullySharedGenericAny L_11 = alloca(SizeOf_T5_tE30F6358E6F6960C5D005F26E5226BE1A88FD104);
	const Il2CppFullySharedGenericAny L_12 = alloca(SizeOf_TR_t30FD969AA0A2A2B632D3CEF7FC3D94F81C759682);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:603>
		ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* L_0 = __this->___parent;
		NullCheck(L_0);
		ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* L_1 = L_0->___resultSelector;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_2 = __this->___c1;
		NullCheck(L_2);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 32)), il2cpp_rgctx_method(method->klass->rgctx_data, 32), L_2, (Il2CppFullySharedGenericAny*)L_3);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_4 = __this->___c2;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 34)), il2cpp_rgctx_method(method->klass->rgctx_data, 34), L_4, (Il2CppFullySharedGenericAny*)L_5);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_6 = __this->___c3;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 36)), il2cpp_rgctx_method(method->klass->rgctx_data, 36), L_6, (Il2CppFullySharedGenericAny*)L_7);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_8 = __this->___c4;
		NullCheck(L_8);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 38)), il2cpp_rgctx_method(method->klass->rgctx_data, 38), L_8, (Il2CppFullySharedGenericAny*)L_9);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_10 = __this->___c5;
		NullCheck(L_10);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 40)), il2cpp_rgctx_method(method->klass->rgctx_data, 40), L_10, (Il2CppFullySharedGenericAny*)L_11);
		NullCheck(L_1);
		InvokerActionInvoker6< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 42)), il2cpp_rgctx_method(method->klass->rgctx_data, 42), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 33)) ? L_3: *(void**)L_3), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 35)) ? L_5: *(void**)L_5), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 37)) ? L_7: *(void**)L_7), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 39)) ? L_9: *(void**)L_9), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 41)) ? L_11: *(void**)L_11), (Il2CppFullySharedGenericAny*)L_12);
		il2cpp_codegen_memcpy(il2cppRetVal, L_12, SizeOf_TR_t30FD969AA0A2A2B632D3CEF7FC3D94F81C759682);
		return;
	}
}
// Method Definition Index: 81092
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnNext_m46E248CB0343144DABA33DD882F8FFDC29A85A47_gshared (ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t30FD969AA0A2A2B632D3CEF7FC3D94F81C759682 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 43));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TR_t30FD969AA0A2A2B632D3CEF7FC3D94F81C759682);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:608>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 43)) ? ___0_value : &___0_value), SizeOf_TR_t30FD969AA0A2A2B632D3CEF7FC3D94F81C759682);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 43)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:609>
		return;
	}
}
// Method Definition Index: 81093
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnError_m4DDF749F2A1809EA24E36B4EE29265DF38F0920F_gshared (ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:614>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 48)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 48));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:614>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:613>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:613>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:615>
		return;
	}
}
// Method Definition Index: 81094
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnCompleted_mD56F7C08C730953364A82D557EC6A24908E54BDB_gshared (ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:620>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 48)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 48));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:620>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:619>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:619>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:621>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81097
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest__ctor_mED26DF047B41E2FF856B9F65B512B457049D20BC_gshared (ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1* __this, int32_t ___0_length, ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* ___1_parent, RuntimeObject* ___2_observer, RuntimeObject* ___3_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:670>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:679>
		int32_t L_1 = ___0_length;
		RuntimeObject* L_2 = ___2_observer;
		RuntimeObject* L_3 = ___3_cancel;
		((  void (*) (NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857*, int32_t, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))((NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857*)__this, L_1, L_2, L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:681>
		ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* L_4 = ___1_parent;
		__this->___parent = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:682>
		return;
	}
}
// Method Definition Index: 81098
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatest_Run_m8FC1133BFD117C7125C4897D0E3AE4113A9DF549_gshared (ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	RuntimeObject* V_3 = NULL;
	RuntimeObject* V_4 = NULL;
	RuntimeObject* V_5 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:686>
		RuntimeObject* L_0 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_1 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 6));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_1, L_0, (RuntimeObject*)__this, 0, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		__this->___c1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c1), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:687>
		RuntimeObject* L_2 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_3 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 8));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_3, L_2, (RuntimeObject*)__this, 1, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		__this->___c2 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c2), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:688>
		RuntimeObject* L_4 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_5 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 10));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_5, L_4, (RuntimeObject*)__this, 2, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		__this->___c3 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c3), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:689>
		RuntimeObject* L_6 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_7 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 12));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 13)))(L_7, L_6, (RuntimeObject*)__this, 3, il2cpp_rgctx_method(method->klass->rgctx_data, 13));
		__this->___c4 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c4), (void*)L_7);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:690>
		RuntimeObject* L_8 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_9 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 14));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 15)))(L_9, L_8, (RuntimeObject*)__this, 4, il2cpp_rgctx_method(method->klass->rgctx_data, 15));
		__this->___c5 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c5), (void*)L_9);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:691>
		RuntimeObject* L_10 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_11 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 16));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 17)))(L_11, L_10, (RuntimeObject*)__this, 5, il2cpp_rgctx_method(method->klass->rgctx_data, 17));
		__this->___c6 = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c6), (void*)L_11);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:693>
		ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* L_12 = __this->___parent;
		NullCheck(L_12);
		RuntimeObject* L_13 = L_12->___source1;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_14 = __this->___c1;
		NullCheck(L_13);
		RuntimeObject* L_15;
		L_15 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 18), L_13, (RuntimeObject*)L_14);
		V_0 = L_15;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:694>
		ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* L_16 = __this->___parent;
		NullCheck(L_16);
		RuntimeObject* L_17 = L_16->___source2;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_18 = __this->___c2;
		NullCheck(L_17);
		RuntimeObject* L_19;
		L_19 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 21), L_17, (RuntimeObject*)L_18);
		V_1 = L_19;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:695>
		ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* L_20 = __this->___parent;
		NullCheck(L_20);
		RuntimeObject* L_21 = L_20->___source3;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_22 = __this->___c3;
		NullCheck(L_21);
		RuntimeObject* L_23;
		L_23 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 24), L_21, (RuntimeObject*)L_22);
		V_2 = L_23;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:696>
		ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* L_24 = __this->___parent;
		NullCheck(L_24);
		RuntimeObject* L_25 = L_24->___source4;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_26 = __this->___c4;
		NullCheck(L_25);
		RuntimeObject* L_27;
		L_27 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 27), L_25, (RuntimeObject*)L_26);
		V_3 = L_27;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:697>
		ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* L_28 = __this->___parent;
		NullCheck(L_28);
		RuntimeObject* L_29 = L_28->___source5;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_30 = __this->___c5;
		NullCheck(L_29);
		RuntimeObject* L_31;
		L_31 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 30), L_29, (RuntimeObject*)L_30);
		V_4 = L_31;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:698>
		ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* L_32 = __this->___parent;
		NullCheck(L_32);
		RuntimeObject* L_33 = L_32->___source6;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_34 = __this->___c6;
		NullCheck(L_33);
		RuntimeObject* L_35;
		L_35 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 33), L_33, (RuntimeObject*)L_34);
		V_5 = L_35;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:700>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_36 = (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)SZArrayNew(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var, (uint32_t)6);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_37 = L_36;
		RuntimeObject* L_38 = V_0;
		NullCheck(L_37);
		ArrayElementTypeCheck (L_37, L_38);
		(L_37)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_38);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_39 = L_37;
		RuntimeObject* L_40 = V_1;
		NullCheck(L_39);
		ArrayElementTypeCheck (L_39, L_40);
		(L_39)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_40);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_41 = L_39;
		RuntimeObject* L_42 = V_2;
		NullCheck(L_41);
		ArrayElementTypeCheck (L_41, L_42);
		(L_41)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_42);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_43 = L_41;
		RuntimeObject* L_44 = V_3;
		NullCheck(L_43);
		ArrayElementTypeCheck (L_43, L_44);
		(L_43)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_44);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_45 = L_43;
		RuntimeObject* L_46 = V_4;
		NullCheck(L_45);
		ArrayElementTypeCheck (L_45, L_46);
		(L_45)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_46);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_47 = L_45;
		RuntimeObject* L_48 = V_5;
		NullCheck(L_47);
		ArrayElementTypeCheck (L_47, L_48);
		(L_47)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject*)L_48);
		RuntimeObject* L_49;
		L_49 = StableCompositeDisposable_Create_mFC6500B00F009673E99112947958DF4058759242(L_47, NULL);
		return (RuntimeObject*)L_49;
	}
}
// Method Definition Index: 81099
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_GetResult_m45E2BDF0FCBC67CE6A8B2DB2FAED4E97B73CAB2B_gshared (ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_tB514854FD5B19933EDCF965D6DBDECF68A9CD14A = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 50));
	const uint32_t SizeOf_T1_tE616530F091739B9082842CA795A20B16FBED5B2 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 38));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T1_tE616530F091739B9082842CA795A20B16FBED5B2);
	const uint32_t SizeOf_T2_tF769938C858855332D2D19B8CDD3BF2724F9D369 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 40));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T2_tF769938C858855332D2D19B8CDD3BF2724F9D369);
	const uint32_t SizeOf_T3_t590F97488A69E302E555DDBFF98D5612C6D2E422 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 42));
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_T3_t590F97488A69E302E555DDBFF98D5612C6D2E422);
	const uint32_t SizeOf_T4_tE90C6EC3048FE5C7434CC6F4A0B845F27A071FF7 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 44));
	const Il2CppFullySharedGenericAny L_9 = alloca(SizeOf_T4_tE90C6EC3048FE5C7434CC6F4A0B845F27A071FF7);
	const uint32_t SizeOf_T5_t5AFF452DF0F31FC423FEC376E91341D167FA10F7 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 46));
	const Il2CppFullySharedGenericAny L_11 = alloca(SizeOf_T5_t5AFF452DF0F31FC423FEC376E91341D167FA10F7);
	const uint32_t SizeOf_T6_t70C23C2088EA6108A9FE6F26FBB704C47A241012 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 48));
	const Il2CppFullySharedGenericAny L_13 = alloca(SizeOf_T6_t70C23C2088EA6108A9FE6F26FBB704C47A241012);
	const Il2CppFullySharedGenericAny L_14 = alloca(SizeOf_TR_tB514854FD5B19933EDCF965D6DBDECF68A9CD14A);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:705>
		ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* L_0 = __this->___parent;
		NullCheck(L_0);
		ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* L_1 = L_0->___resultSelector;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_2 = __this->___c1;
		NullCheck(L_2);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 37)), il2cpp_rgctx_method(method->klass->rgctx_data, 37), L_2, (Il2CppFullySharedGenericAny*)L_3);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_4 = __this->___c2;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 39)), il2cpp_rgctx_method(method->klass->rgctx_data, 39), L_4, (Il2CppFullySharedGenericAny*)L_5);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_6 = __this->___c3;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 41)), il2cpp_rgctx_method(method->klass->rgctx_data, 41), L_6, (Il2CppFullySharedGenericAny*)L_7);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_8 = __this->___c4;
		NullCheck(L_8);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 43)), il2cpp_rgctx_method(method->klass->rgctx_data, 43), L_8, (Il2CppFullySharedGenericAny*)L_9);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_10 = __this->___c5;
		NullCheck(L_10);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 45)), il2cpp_rgctx_method(method->klass->rgctx_data, 45), L_10, (Il2CppFullySharedGenericAny*)L_11);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_12 = __this->___c6;
		NullCheck(L_12);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 47)), il2cpp_rgctx_method(method->klass->rgctx_data, 47), L_12, (Il2CppFullySharedGenericAny*)L_13);
		NullCheck(L_1);
		InvokerActionInvoker7< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 49)), il2cpp_rgctx_method(method->klass->rgctx_data, 49), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 38)) ? L_3: *(void**)L_3), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 40)) ? L_5: *(void**)L_5), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 42)) ? L_7: *(void**)L_7), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 44)) ? L_9: *(void**)L_9), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 46)) ? L_11: *(void**)L_11), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 48)) ? L_13: *(void**)L_13), (Il2CppFullySharedGenericAny*)L_14);
		il2cpp_codegen_memcpy(il2cppRetVal, L_14, SizeOf_TR_tB514854FD5B19933EDCF965D6DBDECF68A9CD14A);
		return;
	}
}
// Method Definition Index: 81100
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnNext_m751819E543BB36F5CBD4FF5C088367DA75490AB0_gshared (ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_tB514854FD5B19933EDCF965D6DBDECF68A9CD14A = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 50));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TR_tB514854FD5B19933EDCF965D6DBDECF68A9CD14A);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:710>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 50)) ? ___0_value : &___0_value), SizeOf_TR_tB514854FD5B19933EDCF965D6DBDECF68A9CD14A);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 50)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:711>
		return;
	}
}
// Method Definition Index: 81101
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnError_mE29A052D446C3CE38437A55A6EF4BE2BC7E364AE_gshared (ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:716>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 55)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 55));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:716>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:715>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:715>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:717>
		return;
	}
}
// Method Definition Index: 81102
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnCompleted_mA297A51DBCD12E1AB5B0EA374A1672023756BFE0_gshared (ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:722>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 55)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 55));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:722>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:721>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:721>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:723>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81105
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest__ctor_mC9EC54B2F3D9BA69798BF31FBF0D230F45FD96EC_gshared (ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D* __this, int32_t ___0_length, ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* ___1_parent, RuntimeObject* ___2_observer, RuntimeObject* ___3_cancel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:776>
		RuntimeObject* L_0 = (RuntimeObject*)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(L_0, NULL);
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:786>
		int32_t L_1 = ___0_length;
		RuntimeObject* L_2 = ___2_observer;
		RuntimeObject* L_3 = ___3_cancel;
		((  void (*) (NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857*, int32_t, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 2)))((NthZipLatestObserverBase_1_tBCB10E70529E0044C39B8693B82D7F6BBE898857*)__this, L_1, L_2, L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 2));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:788>
		ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* L_4 = ___1_parent;
		__this->___parent = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:789>
		return;
	}
}
// Method Definition Index: 81106
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatest_Run_m7A50DAD9AFFD8EA98B8A84CDD1A633EED07773B6_gshared (ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	RuntimeObject* V_3 = NULL;
	RuntimeObject* V_4 = NULL;
	RuntimeObject* V_5 = NULL;
	RuntimeObject* V_6 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:793>
		RuntimeObject* L_0 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_1 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 6));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_1, L_0, (RuntimeObject*)__this, 0, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		__this->___c1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c1), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:794>
		RuntimeObject* L_2 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_3 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 8));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_3, L_2, (RuntimeObject*)__this, 1, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		__this->___c2 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c2), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:795>
		RuntimeObject* L_4 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_5 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 10));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_5, L_4, (RuntimeObject*)__this, 2, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		__this->___c3 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c3), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:796>
		RuntimeObject* L_6 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_7 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 12));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 13)))(L_7, L_6, (RuntimeObject*)__this, 3, il2cpp_rgctx_method(method->klass->rgctx_data, 13));
		__this->___c4 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c4), (void*)L_7);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:797>
		RuntimeObject* L_8 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_9 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 14));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 15)))(L_9, L_8, (RuntimeObject*)__this, 4, il2cpp_rgctx_method(method->klass->rgctx_data, 15));
		__this->___c5 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c5), (void*)L_9);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:798>
		RuntimeObject* L_10 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_11 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 16));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 17)))(L_11, L_10, (RuntimeObject*)__this, 5, il2cpp_rgctx_method(method->klass->rgctx_data, 17));
		__this->___c6 = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c6), (void*)L_11);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:799>
		RuntimeObject* L_12 = __this->___gate;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_13 = (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 18));
		((  void (*) (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5*, RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 19)))(L_13, L_12, (RuntimeObject*)__this, 6, il2cpp_rgctx_method(method->klass->rgctx_data, 19));
		__this->___c7 = L_13;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___c7), (void*)L_13);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:801>
		ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* L_14 = __this->___parent;
		NullCheck(L_14);
		RuntimeObject* L_15 = L_14->___source1;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_16 = __this->___c1;
		NullCheck(L_15);
		RuntimeObject* L_17;
		L_17 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 20), L_15, (RuntimeObject*)L_16);
		V_0 = L_17;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:802>
		ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* L_18 = __this->___parent;
		NullCheck(L_18);
		RuntimeObject* L_19 = L_18->___source2;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_20 = __this->___c2;
		NullCheck(L_19);
		RuntimeObject* L_21;
		L_21 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 23), L_19, (RuntimeObject*)L_20);
		V_1 = L_21;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:803>
		ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* L_22 = __this->___parent;
		NullCheck(L_22);
		RuntimeObject* L_23 = L_22->___source3;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_24 = __this->___c3;
		NullCheck(L_23);
		RuntimeObject* L_25;
		L_25 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 26), L_23, (RuntimeObject*)L_24);
		V_2 = L_25;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:804>
		ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* L_26 = __this->___parent;
		NullCheck(L_26);
		RuntimeObject* L_27 = L_26->___source4;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_28 = __this->___c4;
		NullCheck(L_27);
		RuntimeObject* L_29;
		L_29 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 29), L_27, (RuntimeObject*)L_28);
		V_3 = L_29;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:805>
		ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* L_30 = __this->___parent;
		NullCheck(L_30);
		RuntimeObject* L_31 = L_30->___source5;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_32 = __this->___c5;
		NullCheck(L_31);
		RuntimeObject* L_33;
		L_33 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 32), L_31, (RuntimeObject*)L_32);
		V_4 = L_33;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:806>
		ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* L_34 = __this->___parent;
		NullCheck(L_34);
		RuntimeObject* L_35 = L_34->___source6;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_36 = __this->___c6;
		NullCheck(L_35);
		RuntimeObject* L_37;
		L_37 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 35), L_35, (RuntimeObject*)L_36);
		V_5 = L_37;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:807>
		ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* L_38 = __this->___parent;
		NullCheck(L_38);
		RuntimeObject* L_39 = L_38->___source7;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_40 = __this->___c7;
		NullCheck(L_39);
		RuntimeObject* L_41;
		L_41 = InterfaceFuncInvoker1< RuntimeObject*, RuntimeObject* >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 38), L_39, (RuntimeObject*)L_40);
		V_6 = L_41;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:809>
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_42 = (IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE*)SZArrayNew(IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE_il2cpp_TypeInfo_var, (uint32_t)7);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_43 = L_42;
		RuntimeObject* L_44 = V_0;
		NullCheck(L_43);
		ArrayElementTypeCheck (L_43, L_44);
		(L_43)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject*)L_44);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_45 = L_43;
		RuntimeObject* L_46 = V_1;
		NullCheck(L_45);
		ArrayElementTypeCheck (L_45, L_46);
		(L_45)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject*)L_46);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_47 = L_45;
		RuntimeObject* L_48 = V_2;
		NullCheck(L_47);
		ArrayElementTypeCheck (L_47, L_48);
		(L_47)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject*)L_48);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_49 = L_47;
		RuntimeObject* L_50 = V_3;
		NullCheck(L_49);
		ArrayElementTypeCheck (L_49, L_50);
		(L_49)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject*)L_50);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_51 = L_49;
		RuntimeObject* L_52 = V_4;
		NullCheck(L_51);
		ArrayElementTypeCheck (L_51, L_52);
		(L_51)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject*)L_52);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_53 = L_51;
		RuntimeObject* L_54 = V_5;
		NullCheck(L_53);
		ArrayElementTypeCheck (L_53, L_54);
		(L_53)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject*)L_54);
		IDisposableU5BU5D_t7D2E88760CCE6C653A28D1DB1108AFA898478DEE* L_55 = L_53;
		RuntimeObject* L_56 = V_6;
		NullCheck(L_55);
		ArrayElementTypeCheck (L_55, L_56);
		(L_55)->SetAt(static_cast<il2cpp_array_size_t>(6), (RuntimeObject*)L_56);
		RuntimeObject* L_57;
		L_57 = StableCompositeDisposable_Create_mFC6500B00F009673E99112947958DF4058759242(L_55, NULL);
		return (RuntimeObject*)L_57;
	}
}
// Method Definition Index: 81107
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_GetResult_m19E9FA8AD4DB87800B1E6DFD51FC968E984CD42C_gshared (ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t6799EDEA6F6C24EC0EDBAC35DE417647368508F7 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 57));
	const uint32_t SizeOf_T1_t5BCD11EAF9F07F4C2E2C633A319DB369E8B1DF32 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 43));
	const Il2CppFullySharedGenericAny L_3 = alloca(SizeOf_T1_t5BCD11EAF9F07F4C2E2C633A319DB369E8B1DF32);
	const uint32_t SizeOf_T2_t7ED8B3870FE5E20136ABE1B7C9A3E5C22384A7A9 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 45));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T2_t7ED8B3870FE5E20136ABE1B7C9A3E5C22384A7A9);
	const uint32_t SizeOf_T3_tFD90455AB0DD8AF2167A1CBFD62514FEF02991B5 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 47));
	const Il2CppFullySharedGenericAny L_7 = alloca(SizeOf_T3_tFD90455AB0DD8AF2167A1CBFD62514FEF02991B5);
	const uint32_t SizeOf_T4_t96D68966B3A1383483D137865C1231910913D197 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 49));
	const Il2CppFullySharedGenericAny L_9 = alloca(SizeOf_T4_t96D68966B3A1383483D137865C1231910913D197);
	const uint32_t SizeOf_T5_t449B1CA4D9DCF8B3E93DCF684D7D3C907FA39F25 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 51));
	const Il2CppFullySharedGenericAny L_11 = alloca(SizeOf_T5_t449B1CA4D9DCF8B3E93DCF684D7D3C907FA39F25);
	const uint32_t SizeOf_T6_tE4D65522AF4C74F5E5CBF40D51B4E6A9CB61271A = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 53));
	const Il2CppFullySharedGenericAny L_13 = alloca(SizeOf_T6_tE4D65522AF4C74F5E5CBF40D51B4E6A9CB61271A);
	const uint32_t SizeOf_T7_t4897B3293F07028878D136A1A7BE422D0CD9C695 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 55));
	const Il2CppFullySharedGenericAny L_15 = alloca(SizeOf_T7_t4897B3293F07028878D136A1A7BE422D0CD9C695);
	const Il2CppFullySharedGenericAny L_16 = alloca(SizeOf_TR_t6799EDEA6F6C24EC0EDBAC35DE417647368508F7);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:814>
		ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* L_0 = __this->___parent;
		NullCheck(L_0);
		ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* L_1 = L_0->___resultSelector;
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_2 = __this->___c1;
		NullCheck(L_2);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 42)), il2cpp_rgctx_method(method->klass->rgctx_data, 42), L_2, (Il2CppFullySharedGenericAny*)L_3);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_4 = __this->___c2;
		NullCheck(L_4);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 44)), il2cpp_rgctx_method(method->klass->rgctx_data, 44), L_4, (Il2CppFullySharedGenericAny*)L_5);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_6 = __this->___c3;
		NullCheck(L_6);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 46)), il2cpp_rgctx_method(method->klass->rgctx_data, 46), L_6, (Il2CppFullySharedGenericAny*)L_7);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_8 = __this->___c4;
		NullCheck(L_8);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 48)), il2cpp_rgctx_method(method->klass->rgctx_data, 48), L_8, (Il2CppFullySharedGenericAny*)L_9);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_10 = __this->___c5;
		NullCheck(L_10);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 50)), il2cpp_rgctx_method(method->klass->rgctx_data, 50), L_10, (Il2CppFullySharedGenericAny*)L_11);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_12 = __this->___c6;
		NullCheck(L_12);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 52)), il2cpp_rgctx_method(method->klass->rgctx_data, 52), L_12, (Il2CppFullySharedGenericAny*)L_13);
		ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* L_14 = __this->___c7;
		NullCheck(L_14);
		InvokerActionInvoker1< Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 54)), il2cpp_rgctx_method(method->klass->rgctx_data, 54), L_14, (Il2CppFullySharedGenericAny*)L_15);
		NullCheck(L_1);
		InvokerActionInvoker8< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 56)), il2cpp_rgctx_method(method->klass->rgctx_data, 56), L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 43)) ? L_3: *(void**)L_3), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 45)) ? L_5: *(void**)L_5), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 47)) ? L_7: *(void**)L_7), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 49)) ? L_9: *(void**)L_9), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 51)) ? L_11: *(void**)L_11), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 53)) ? L_13: *(void**)L_13), (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 55)) ? L_15: *(void**)L_15), (Il2CppFullySharedGenericAny*)L_16);
		il2cpp_codegen_memcpy(il2cppRetVal, L_16, SizeOf_TR_t6799EDEA6F6C24EC0EDBAC35DE417647368508F7);
		return;
	}
}
// Method Definition Index: 81108
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnNext_m878B70C00E0D089E93BDAA8A1575D6815E984C13_gshared (ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_TR_t6799EDEA6F6C24EC0EDBAC35DE417647368508F7 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 57));
	const Il2CppFullySharedGenericAny L_1 = alloca(SizeOf_TR_t6799EDEA6F6C24EC0EDBAC35DE417647368508F7);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:819>
		RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
		il2cpp_codegen_memory_barrier();
		il2cpp_codegen_memcpy(L_1, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 57)) ? ___0_value : &___0_value), SizeOf_TR_t6799EDEA6F6C24EC0EDBAC35DE417647368508F7);
		NullCheck(L_0);
		InterfaceActionInvoker1Invoker< Il2CppFullySharedGenericAny >::Invoke(0, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 57)) ? L_1: *(void**)L_1));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:820>
		return;
	}
}
// Method Definition Index: 81109
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnError_mE07D2C5A0B6D2E14695DF1B8545284E97962E50F_gshared (ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:825>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 62)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 62));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:825>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:824>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			Exception_t* L_1 = ___0_error;
			NullCheck(L_0);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0, L_1);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:824>
			goto IL_0017;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0017:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:826>
		return;
	}
}
// Method Definition Index: 81110
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatest_OnCompleted_m1916EA2ECA1D6B56574E24C133BD46A9231E65AA_gshared (ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D* __this, const RuntimeMethod* method) 
{
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_000f:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:831>
				NullCheck((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this);
				((  void (*) (OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 62)))((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this, il2cpp_rgctx_method(method->klass->rgctx_data, 62));
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:831>
				return;
			}
		});
		try
		{
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:830>
			RuntimeObject* L_0 = ((OperatorObserverBase_2_tB7D10DE201033653F9FAA9EC71ECBD88D2901B37*)__this)->___observer;
			il2cpp_codegen_memory_barrier();
			NullCheck(L_0);
			InterfaceActionInvoker0::Invoke(2, il2cpp_rgctx_data(method->klass->rgctx_data, 1), L_0);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:830>
			goto IL_0016;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0016:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:832>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_Multicast(ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* currentDelegate = reinterpret_cast<ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenStaticInvoker(ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker4< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_ClosedStaticInvoker(ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker5< RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_ClosedInstInvoker(ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker4< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenInstInvoker(ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InvokerActionInvoker3< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenVirtualInvoker(ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	VirtualActionInvoker3Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenInterfaceInvoker(ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InterfaceActionInvoker3Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenGenericVirtualInvoker(ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericVirtualActionInvoker3Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
void ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenGenericInterfaceInvoker(ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericInterfaceActionInvoker3Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal);
}
// Method Definition Index: 81023
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_4__ctor_m4741F2AF524CFF0F4D12A33D06D71D9A5E99C67D_gshared (ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 3;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 2;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenGenericInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenGenericVirtualInvoker;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenVirtualInvoker;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_OpenInstInvoker;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_Multicast;
}
// Method Definition Index: 81024
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_4_Invoke_m63A4FE7B266B967E9F569AA130A480495FF2AE61_gshared (ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 81025
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestFunc_4_BeginInvoke_m4645C98B7F87CB6EA50C5091DFDBC2FCBA6E4DBC_gshared (ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___3_callback, RuntimeObject* ___4_object, const RuntimeMethod* method) 
{
	void *__d_args[4] = {0};
	RuntimeClass* ___0_arg1_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 0));
	__d_args[0] = (il2cpp_codegen_class_is_value_type(___0_arg1_klass) ? Box(___0_arg1_klass, ___0_arg1) : (void*)___0_arg1);
	RuntimeClass* ___1_arg2_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 1));
	__d_args[1] = (il2cpp_codegen_class_is_value_type(___1_arg2_klass) ? Box(___1_arg2_klass, ___1_arg2) : (void*)___1_arg2);
	RuntimeClass* ___2_arg3_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 2));
	__d_args[2] = (il2cpp_codegen_class_is_value_type(___2_arg3_klass) ? Box(___2_arg3_klass, ___2_arg3) : (void*)___2_arg3);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___3_callback, (RuntimeObject*)___4_object);
}
// Method Definition Index: 81026
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_4_EndInvoke_m0E1DF8C5F56046D8CF54CBE9A58EABDB2A13021B_gshared (ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* __this, RuntimeObject* ___0_result, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
	RuntimeClass* returnType = il2cpp_codegen_class_from_type(il2cpp_codegen_method_return_type((MethodInfo*)__this->___method));
	uint32_t returnTypeSize = il2cpp_codegen_sizeof(returnType);
	void* unboxStorage = alloca(returnTypeSize);
	void* unboxed = UnBox_Any((RuntimeObject*)__result, returnType, unboxStorage);
	il2cpp_codegen_memcpy(il2cppRetVal, unboxed, returnTypeSize);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_Multicast(ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* currentDelegate = reinterpret_cast<ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenStaticInvoker(ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker5< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_ClosedStaticInvoker(ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker6< RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_ClosedInstInvoker(ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker5< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenInstInvoker(ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InvokerActionInvoker4< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenVirtualInvoker(ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	VirtualActionInvoker4Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenInterfaceInvoker(ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InterfaceActionInvoker4Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenGenericVirtualInvoker(ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericVirtualActionInvoker4Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
void ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenGenericInterfaceInvoker(ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericInterfaceActionInvoker4Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal);
}
// Method Definition Index: 81027
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_5__ctor_mC6BC33C314FBB3D24524796BA7A671F419802297_gshared (ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 4;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 3;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenGenericInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenGenericVirtualInvoker;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenVirtualInvoker;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_OpenInstInvoker;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_Multicast;
}
// Method Definition Index: 81028
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_5_Invoke_mFE2CA87CF8AF4BF7A5FE9DC991377C25B1272F12_gshared (ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 81029
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestFunc_5_BeginInvoke_m04878F441E952F963FEA3CB201482906C69A22F0_gshared (ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___4_callback, RuntimeObject* ___5_object, const RuntimeMethod* method) 
{
	void *__d_args[5] = {0};
	RuntimeClass* ___0_arg1_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 0));
	__d_args[0] = (il2cpp_codegen_class_is_value_type(___0_arg1_klass) ? Box(___0_arg1_klass, ___0_arg1) : (void*)___0_arg1);
	RuntimeClass* ___1_arg2_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 1));
	__d_args[1] = (il2cpp_codegen_class_is_value_type(___1_arg2_klass) ? Box(___1_arg2_klass, ___1_arg2) : (void*)___1_arg2);
	RuntimeClass* ___2_arg3_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 2));
	__d_args[2] = (il2cpp_codegen_class_is_value_type(___2_arg3_klass) ? Box(___2_arg3_klass, ___2_arg3) : (void*)___2_arg3);
	RuntimeClass* ___3_arg4_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 3));
	__d_args[3] = (il2cpp_codegen_class_is_value_type(___3_arg4_klass) ? Box(___3_arg4_klass, ___3_arg4) : (void*)___3_arg4);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___4_callback, (RuntimeObject*)___5_object);
}
// Method Definition Index: 81030
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_5_EndInvoke_mE9B71C166E5FD0D4C5EA6048C80BB1E11C4AA25D_gshared (ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* __this, RuntimeObject* ___0_result, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
	RuntimeClass* returnType = il2cpp_codegen_class_from_type(il2cpp_codegen_method_return_type((MethodInfo*)__this->___method));
	uint32_t returnTypeSize = il2cpp_codegen_sizeof(returnType);
	void* unboxStorage = alloca(returnTypeSize);
	void* unboxed = UnBox_Any((RuntimeObject*)__result, returnType, unboxStorage);
	il2cpp_codegen_memcpy(il2cppRetVal, unboxed, returnTypeSize);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_Multicast(ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* currentDelegate = reinterpret_cast<ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenStaticInvoker(ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker6< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_ClosedStaticInvoker(ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker7< RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_ClosedInstInvoker(ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker6< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenInstInvoker(ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InvokerActionInvoker5< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenVirtualInvoker(ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	VirtualActionInvoker5Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenInterfaceInvoker(ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InterfaceActionInvoker5Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenGenericVirtualInvoker(ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericVirtualActionInvoker5Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
void ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenGenericInterfaceInvoker(ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericInterfaceActionInvoker5Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal);
}
// Method Definition Index: 81031
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_6__ctor_m91E175D3A31577392C0976E6721861C42A5D206B_gshared (ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 5;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 4;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenGenericInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenGenericVirtualInvoker;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenVirtualInvoker;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_OpenInstInvoker;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_Multicast;
}
// Method Definition Index: 81032
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_6_Invoke_m132C1426C0C5418273914DAB827DEF13B2DDEB73_gshared (ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 81033
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestFunc_6_BeginInvoke_m4BCF84FCC19B37ABB41D80C1387B552710669038_gshared (ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___5_callback, RuntimeObject* ___6_object, const RuntimeMethod* method) 
{
	void *__d_args[6] = {0};
	RuntimeClass* ___0_arg1_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 0));
	__d_args[0] = (il2cpp_codegen_class_is_value_type(___0_arg1_klass) ? Box(___0_arg1_klass, ___0_arg1) : (void*)___0_arg1);
	RuntimeClass* ___1_arg2_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 1));
	__d_args[1] = (il2cpp_codegen_class_is_value_type(___1_arg2_klass) ? Box(___1_arg2_klass, ___1_arg2) : (void*)___1_arg2);
	RuntimeClass* ___2_arg3_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 2));
	__d_args[2] = (il2cpp_codegen_class_is_value_type(___2_arg3_klass) ? Box(___2_arg3_klass, ___2_arg3) : (void*)___2_arg3);
	RuntimeClass* ___3_arg4_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 3));
	__d_args[3] = (il2cpp_codegen_class_is_value_type(___3_arg4_klass) ? Box(___3_arg4_klass, ___3_arg4) : (void*)___3_arg4);
	RuntimeClass* ___4_arg5_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 4));
	__d_args[4] = (il2cpp_codegen_class_is_value_type(___4_arg5_klass) ? Box(___4_arg5_klass, ___4_arg5) : (void*)___4_arg5);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___5_callback, (RuntimeObject*)___6_object);
}
// Method Definition Index: 81034
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_6_EndInvoke_mEB6C2B876473DFA31D279A1EB41D639A6E14A503_gshared (ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* __this, RuntimeObject* ___0_result, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
	RuntimeClass* returnType = il2cpp_codegen_class_from_type(il2cpp_codegen_method_return_type((MethodInfo*)__this->___method));
	uint32_t returnTypeSize = il2cpp_codegen_sizeof(returnType);
	void* unboxStorage = alloca(returnTypeSize);
	void* unboxed = UnBox_Any((RuntimeObject*)__result, returnType, unboxStorage);
	il2cpp_codegen_memcpy(il2cppRetVal, unboxed, returnTypeSize);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_Multicast(ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* currentDelegate = reinterpret_cast<ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenStaticInvoker(ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker7< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_ClosedStaticInvoker(ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker8< RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_ClosedInstInvoker(ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker7< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenInstInvoker(ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InvokerActionInvoker6< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenVirtualInvoker(ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	VirtualActionInvoker6Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenInterfaceInvoker(ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InterfaceActionInvoker6Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenGenericVirtualInvoker(ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericVirtualActionInvoker6Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
void ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenGenericInterfaceInvoker(ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericInterfaceActionInvoker6Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal);
}
// Method Definition Index: 81035
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_7__ctor_m3EA022BE924327746D1F1C2CC0F380DC5E2E1934_gshared (ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 6;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 5;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenGenericInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenGenericVirtualInvoker;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenVirtualInvoker;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_OpenInstInvoker;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_Multicast;
}
// Method Definition Index: 81036
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_7_Invoke_m379AB6C3273653B33682374D62C10C6D3CDFEAB4_gshared (ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 81037
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestFunc_7_BeginInvoke_m09C29D72B1042B9A97F4818007BA07D3D3F1C8B5_gshared (ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___6_callback, RuntimeObject* ___7_object, const RuntimeMethod* method) 
{
	void *__d_args[7] = {0};
	RuntimeClass* ___0_arg1_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 0));
	__d_args[0] = (il2cpp_codegen_class_is_value_type(___0_arg1_klass) ? Box(___0_arg1_klass, ___0_arg1) : (void*)___0_arg1);
	RuntimeClass* ___1_arg2_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 1));
	__d_args[1] = (il2cpp_codegen_class_is_value_type(___1_arg2_klass) ? Box(___1_arg2_klass, ___1_arg2) : (void*)___1_arg2);
	RuntimeClass* ___2_arg3_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 2));
	__d_args[2] = (il2cpp_codegen_class_is_value_type(___2_arg3_klass) ? Box(___2_arg3_klass, ___2_arg3) : (void*)___2_arg3);
	RuntimeClass* ___3_arg4_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 3));
	__d_args[3] = (il2cpp_codegen_class_is_value_type(___3_arg4_klass) ? Box(___3_arg4_klass, ___3_arg4) : (void*)___3_arg4);
	RuntimeClass* ___4_arg5_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 4));
	__d_args[4] = (il2cpp_codegen_class_is_value_type(___4_arg5_klass) ? Box(___4_arg5_klass, ___4_arg5) : (void*)___4_arg5);
	RuntimeClass* ___5_arg6_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 5));
	__d_args[5] = (il2cpp_codegen_class_is_value_type(___5_arg6_klass) ? Box(___5_arg6_klass, ___5_arg6) : (void*)___5_arg6);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___6_callback, (RuntimeObject*)___7_object);
}
// Method Definition Index: 81038
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_7_EndInvoke_m58DDA221CF42FAAFC4E087F47926721D02F0B47A_gshared (ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* __this, RuntimeObject* ___0_result, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
	RuntimeClass* returnType = il2cpp_codegen_class_from_type(il2cpp_codegen_method_return_type((MethodInfo*)__this->___method));
	uint32_t returnTypeSize = il2cpp_codegen_sizeof(returnType);
	void* unboxStorage = alloca(returnTypeSize);
	void* unboxed = UnBox_Any((RuntimeObject*)__result, returnType, unboxStorage);
	il2cpp_codegen_memcpy(il2cppRetVal, unboxed, returnTypeSize);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_Multicast(ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* currentDelegate = reinterpret_cast<ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl)((Il2CppObject*)currentDelegate->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method));
	}
}
void ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenStaticInvoker(ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker8< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_ClosedStaticInvoker(ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker9< RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, NULL, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_ClosedInstInvoker(ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	InvokerActionInvoker8< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, __this->___m_target, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenInstInvoker(ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InvokerActionInvoker7< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke((Il2CppMethodPointer)__this->___method_ptr, method, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenVirtualInvoker(ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	VirtualActionInvoker7Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenInterfaceInvoker(ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	InterfaceActionInvoker7Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(il2cpp_codegen_method_get_slot(method), il2cpp_codegen_method_get_declaring_type(method), (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenGenericVirtualInvoker(ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericVirtualActionInvoker7Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
void ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenGenericInterfaceInvoker(ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method)
{
	NullCheck(___0_arg1);
	GenericInterfaceActionInvoker7Invoker< Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny* >::Invoke(method, (RuntimeObject*)___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal);
}
// Method Definition Index: 81039
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_8__ctor_m4AF3D60C1ED4C09161D1AEEEE124477C8BE527E3_gshared (ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) 
{
	__this->___method_ptr = (intptr_t)il2cpp_codegen_get_method_pointer((RuntimeMethod*)___1_method);
	__this->___method = ___1_method;
	__this->___m_target = ___0_object;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target), (void*)___0_object);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___1_method);
	__this->___method_code = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___1_method))
	{
		bool isOpen = parameterCount == 7;
		if (isOpen)
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenStaticInvoker;
		else
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_ClosedStaticInvoker;
	}
	else
	{
		bool isOpen = parameterCount == 6;
		if (isOpen)
		{
			if (__this->___method_is_virtual)
			{
				if (il2cpp_codegen_method_is_generic_instance_method((RuntimeMethod*)___1_method))
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenGenericInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenGenericVirtualInvoker;
				else
					if (il2cpp_codegen_method_is_interface_method((RuntimeMethod*)___1_method))
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenInterfaceInvoker;
					else
						__this->___invoke_impl = (intptr_t)&ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenVirtualInvoker;
			}
			else
			{
				__this->___invoke_impl = (intptr_t)&ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_OpenInstInvoker;
			}
		}
		else
		{
			if (___0_object == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl = (intptr_t)&ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_ClosedInstInvoker;
		}
	}
	__this->___extra_arg = (intptr_t)&ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_Multicast;
}
// Method Definition Index: 81040
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_8_Invoke_mAEA6579410482CA5D6E7F81A41ED114E4047654F_gshared (ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny, Il2CppFullySharedGenericAny*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, ___2_arg3, ___3_arg4, ___4_arg5, ___5_arg6, ___6_arg7, il2cppRetVal, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 81041
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestFunc_8_BeginInvoke_m7A03A1A7B306DAF43A98734FD05AA7FD3CF48602_gshared (ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, Il2CppFullySharedGenericAny ___0_arg1, Il2CppFullySharedGenericAny ___1_arg2, Il2CppFullySharedGenericAny ___2_arg3, Il2CppFullySharedGenericAny ___3_arg4, Il2CppFullySharedGenericAny ___4_arg5, Il2CppFullySharedGenericAny ___5_arg6, Il2CppFullySharedGenericAny ___6_arg7, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___7_callback, RuntimeObject* ___8_object, const RuntimeMethod* method) 
{
	void *__d_args[8] = {0};
	RuntimeClass* ___0_arg1_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 0));
	__d_args[0] = (il2cpp_codegen_class_is_value_type(___0_arg1_klass) ? Box(___0_arg1_klass, ___0_arg1) : (void*)___0_arg1);
	RuntimeClass* ___1_arg2_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 1));
	__d_args[1] = (il2cpp_codegen_class_is_value_type(___1_arg2_klass) ? Box(___1_arg2_klass, ___1_arg2) : (void*)___1_arg2);
	RuntimeClass* ___2_arg3_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 2));
	__d_args[2] = (il2cpp_codegen_class_is_value_type(___2_arg3_klass) ? Box(___2_arg3_klass, ___2_arg3) : (void*)___2_arg3);
	RuntimeClass* ___3_arg4_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 3));
	__d_args[3] = (il2cpp_codegen_class_is_value_type(___3_arg4_klass) ? Box(___3_arg4_klass, ___3_arg4) : (void*)___3_arg4);
	RuntimeClass* ___4_arg5_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 4));
	__d_args[4] = (il2cpp_codegen_class_is_value_type(___4_arg5_klass) ? Box(___4_arg5_klass, ___4_arg5) : (void*)___4_arg5);
	RuntimeClass* ___5_arg6_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 5));
	__d_args[5] = (il2cpp_codegen_class_is_value_type(___5_arg6_klass) ? Box(___5_arg6_klass, ___5_arg6) : (void*)___5_arg6);
	RuntimeClass* ___6_arg7_klass = il2cpp_codegen_class_from_type(il2cpp_codegen_method_parameter_type((MethodInfo*)__this->___method, 6));
	__d_args[6] = (il2cpp_codegen_class_is_value_type(___6_arg7_klass) ? Box(___6_arg7_klass, ___6_arg7) : (void*)___6_arg7);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___7_callback, (RuntimeObject*)___8_object);
}
// Method Definition Index: 81042
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestFunc_8_EndInvoke_mFCBEB6C12B334B46FE0605C2F98646B03E4E1CEC_gshared (ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* __this, RuntimeObject* ___0_result, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___0_result, 0);
	RuntimeClass* returnType = il2cpp_codegen_class_from_type(il2cpp_codegen_method_return_type((MethodInfo*)__this->___method));
	uint32_t returnTypeSize = il2cpp_codegen_sizeof(returnType);
	void* unboxStorage = alloca(returnTypeSize);
	void* unboxed = UnBox_Any((RuntimeObject*)__result, returnType, unboxStorage);
	il2cpp_codegen_memcpy(il2cppRetVal, unboxed, returnTypeSize);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81059
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObservable_1__ctor_mAE5DAEB7CF55FF2EDF366D8DFF857F173DDE3850_gshared (ZipLatestObservable_1_t2A28BD239FCAB16DD9001B4A9F9D9F151D9CD77C* __this, IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035* ___0_sources, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:198>
		((  void (*) (OperatorObservableBase_1_tBFE60A390AADA301289FC0A01C56C68B84E92F41*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 0)))((OperatorObservableBase_1_tBFE60A390AADA301289FC0A01C56C68B84E92F41*)__this, (bool)1, il2cpp_rgctx_method(method->klass->rgctx_data, 0));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:200>
		IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035* L_0 = ___0_sources;
		__this->___sources = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___sources), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:201>
		return;
	}
}
// Method Definition Index: 81060
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestObservable_1_SubscribeCore_m9C9C3A4DAEC8FA5613491CCFBA63112A22E1037E_gshared (ZipLatestObservable_1_t2A28BD239FCAB16DD9001B4A9F9D9F151D9CD77C* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:205>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_2 = (ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 5));
		((  void (*) (ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A*, ZipLatestObservable_1_t2A28BD239FCAB16DD9001B4A9F9D9F151D9CD77C*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))(L_2, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81043
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObservable_3__ctor_m233767A940AB14809669BCE4B5A69EFE6FB7156D_gshared (ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091* __this, RuntimeObject* ___0_left, RuntimeObject* ___1_right, Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* ___2_selector, const RuntimeMethod* method) 
{
	ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091* G_B2_0 = NULL;
	ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091* G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091* G_B3_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:22>
		RuntimeObject* L_0 = ___0_left;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B2_0 = __this;
			goto IL_0011;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_right;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		G_B3_0 = ((int32_t)(L_3));
		G_B3_1 = G_B1_0;
		goto IL_0012;
	}

IL_0011:
	{
		G_B3_0 = 1;
		G_B3_1 = G_B2_0;
	}

IL_0012:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 4)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B3_1, (bool)G_B3_0, il2cpp_rgctx_method(method->klass->rgctx_data, 4));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:24>
		RuntimeObject* L_4 = ___0_left;
		__this->___left = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___left), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:25>
		RuntimeObject* L_5 = ___1_right;
		__this->___right = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___right), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:26>
		Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* L_6 = ___2_selector;
		__this->___selector = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___selector), (void*)L_6);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:27>
		return;
	}
}
// Method Definition Index: 81044
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestObservable_3_SubscribeCore_m3AF7A0B4FC70420595146D1487FCABB41E82C7EA_gshared (ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:31>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527* L_2 = (ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 9));
		((  void (*) (ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527*, ZipLatestObservable_3_t9FA0E9534ABC2E70A7A414F862B3DA4AAFEBF091*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))(L_2, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (ZipLatest_tF5D881A4A019E0AA2E0B9F44AFD82355C5D55527*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81071
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObservable_4__ctor_mE2E8ECA1B847463161F60B608B89D42A1C5EB97F_gshared (ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* __this, RuntimeObject* ___0_source1, RuntimeObject* ___1_source2, RuntimeObject* ___2_source3, ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* ___3_resultSelector, const RuntimeMethod* method) 
{
	ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* G_B3_0 = NULL;
	ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* G_B1_0 = NULL;
	ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* G_B2_0 = NULL;
	int32_t G_B4_0 = 0;
	ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* G_B4_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:374>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:375>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:376>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:377>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:378>
		RuntimeObject* L_0 = ___0_source1;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B3_0 = __this;
			goto IL_0019;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_source2;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		if (L_3)
		{
			G_B3_0 = G_B1_0;
			goto IL_0019;
		}
		G_B2_0 = G_B1_0;
	}
	{
		RuntimeObject* L_4 = ___2_source3;
		bool L_5;
		L_5 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		G_B4_0 = ((int32_t)(L_5));
		G_B4_1 = G_B2_0;
		goto IL_001a;
	}

IL_0019:
	{
		G_B4_0 = 1;
		G_B4_1 = G_B3_0;
	}

IL_001a:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B4_1, (bool)G_B4_0, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:380>
		RuntimeObject* L_6 = ___0_source1;
		__this->___source1 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source1), (void*)L_6);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:381>
		RuntimeObject* L_7 = ___1_source2;
		__this->___source2 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source2), (void*)L_7);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:382>
		RuntimeObject* L_8 = ___2_source3;
		__this->___source3 = L_8;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source3), (void*)L_8);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:383>
		ZipLatestFunc_4_t2FD981F35CF9112A8161F583752BFB379B602DBB* L_9 = ___3_resultSelector;
		__this->___resultSelector = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___resultSelector), (void*)L_9);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:384>
		return;
	}
}
// Method Definition Index: 81072
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestObservable_4_SubscribeCore_mD8C393CF4FA50C7505800439B50C6C70BCCBDE9A_gshared (ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:388>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957* L_2 = (ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 11));
		((  void (*) (ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957*, int32_t, ZipLatestObservable_4_t95B940DAFC395C50E8DAE3A8A2F60952CDA82C04*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))(L_2, 3, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (ZipLatest_tB06DDA82946EADE4929C510258EAC9C8325DC957*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 13)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 13));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81079
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObservable_5__ctor_m12B26273DF768B5CCD6FECAB51C3B4FCDF798046_gshared (ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* __this, RuntimeObject* ___0_source1, RuntimeObject* ___1_source2, RuntimeObject* ___2_source3, RuntimeObject* ___3_source4, ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* ___4_resultSelector, const RuntimeMethod* method) 
{
	ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* G_B4_0 = NULL;
	ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* G_B1_0 = NULL;
	ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* G_B2_0 = NULL;
	ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* G_B3_0 = NULL;
	int32_t G_B5_0 = 0;
	ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* G_B5_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:457>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:458>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:459>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:460>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:461>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:462>
		RuntimeObject* L_0 = ___0_source1;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B4_0 = __this;
			goto IL_0022;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_source2;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		if (L_3)
		{
			G_B4_0 = G_B1_0;
			goto IL_0022;
		}
		G_B2_0 = G_B1_0;
	}
	{
		RuntimeObject* L_4 = ___2_source3;
		bool L_5;
		L_5 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		if (L_5)
		{
			G_B4_0 = G_B2_0;
			goto IL_0022;
		}
		G_B3_0 = G_B2_0;
	}
	{
		RuntimeObject* L_6 = ___3_source4;
		bool L_7;
		L_7 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		G_B5_0 = ((int32_t)(L_7));
		G_B5_1 = G_B3_0;
		goto IL_0023;
	}

IL_0022:
	{
		G_B5_0 = 1;
		G_B5_1 = G_B4_0;
	}

IL_0023:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 8)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B5_1, (bool)G_B5_0, il2cpp_rgctx_method(method->klass->rgctx_data, 8));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:464>
		RuntimeObject* L_8 = ___0_source1;
		__this->___source1 = L_8;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source1), (void*)L_8);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:465>
		RuntimeObject* L_9 = ___1_source2;
		__this->___source2 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source2), (void*)L_9);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:466>
		RuntimeObject* L_10 = ___2_source3;
		__this->___source3 = L_10;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source3), (void*)L_10);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:467>
		RuntimeObject* L_11 = ___3_source4;
		__this->___source4 = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source4), (void*)L_11);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:468>
		ZipLatestFunc_5_tA408937D337B90E99EB6B4DD4E72F5F824A86183* L_12 = ___4_resultSelector;
		__this->___resultSelector = L_12;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___resultSelector), (void*)L_12);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:469>
		return;
	}
}
// Method Definition Index: 81080
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestObservable_5_SubscribeCore_mB49542BE31A5FC28A2A5CDB35B969FDEFF69A052_gshared (ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:473>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D* L_2 = (ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 13));
		((  void (*) (ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D*, int32_t, ZipLatestObservable_5_tBE44A576CACC33D67699EE00A80902E26DB4CC07*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 14)))(L_2, 4, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (ZipLatest_t9521336EDAC2070DB0A15173249136C30A6EEE5D*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 15)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 15));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81087
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObservable_6__ctor_m1E723349D87F93A3563F3DFE86D6DD7B13F0E15F_gshared (ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* __this, RuntimeObject* ___0_source1, RuntimeObject* ___1_source2, RuntimeObject* ___2_source3, RuntimeObject* ___3_source4, RuntimeObject* ___4_source5, ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* ___5_resultSelector, const RuntimeMethod* method) 
{
	ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* G_B5_0 = NULL;
	ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* G_B1_0 = NULL;
	ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* G_B2_0 = NULL;
	ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* G_B3_0 = NULL;
	ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* G_B4_0 = NULL;
	int32_t G_B6_0 = 0;
	ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* G_B6_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:547>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:548>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:549>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:550>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:551>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:552>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:553>
		RuntimeObject* L_0 = ___0_source1;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B5_0 = __this;
			goto IL_002b;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_source2;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		if (L_3)
		{
			G_B5_0 = G_B1_0;
			goto IL_002b;
		}
		G_B2_0 = G_B1_0;
	}
	{
		RuntimeObject* L_4 = ___2_source3;
		bool L_5;
		L_5 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		if (L_5)
		{
			G_B5_0 = G_B2_0;
			goto IL_002b;
		}
		G_B3_0 = G_B2_0;
	}
	{
		RuntimeObject* L_6 = ___3_source4;
		bool L_7;
		L_7 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		if (L_7)
		{
			G_B5_0 = G_B3_0;
			goto IL_002b;
		}
		G_B4_0 = G_B3_0;
	}
	{
		RuntimeObject* L_8 = ___4_source5;
		bool L_9;
		L_9 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		G_B6_0 = ((int32_t)(L_9));
		G_B6_1 = G_B4_0;
		goto IL_002c;
	}

IL_002b:
	{
		G_B6_0 = 1;
		G_B6_1 = G_B5_0;
	}

IL_002c:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B6_1, (bool)G_B6_0, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:555>
		RuntimeObject* L_10 = ___0_source1;
		__this->___source1 = L_10;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source1), (void*)L_10);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:556>
		RuntimeObject* L_11 = ___1_source2;
		__this->___source2 = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source2), (void*)L_11);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:557>
		RuntimeObject* L_12 = ___2_source3;
		__this->___source3 = L_12;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source3), (void*)L_12);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:558>
		RuntimeObject* L_13 = ___3_source4;
		__this->___source4 = L_13;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source4), (void*)L_13);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:559>
		RuntimeObject* L_14 = ___4_source5;
		__this->___source5 = L_14;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source5), (void*)L_14);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:560>
		ZipLatestFunc_6_t905F3CA23D833224E84F6BD8655F8AA71E960E69* L_15 = ___5_resultSelector;
		__this->___resultSelector = L_15;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___resultSelector), (void*)L_15);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:561>
		return;
	}
}
// Method Definition Index: 81088
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestObservable_6_SubscribeCore_m6B4149E541184AFA6392199FE6C6AE9C8E51E673_gshared (ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:565>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2* L_2 = (ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 15));
		((  void (*) (ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2*, int32_t, ZipLatestObservable_6_t7D59C42D7D6B2B5BDC438692526F72659EB963F2*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 16)))(L_2, 5, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 16));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (ZipLatest_t0158DD6DC60DCA1233766799DE055D5AB041E4E2*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 17)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 17));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81095
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObservable_7__ctor_m92291151BFC8591D0E5F83E4A286E16455795ABF_gshared (ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* __this, RuntimeObject* ___0_source1, RuntimeObject* ___1_source2, RuntimeObject* ___2_source3, RuntimeObject* ___3_source4, RuntimeObject* ___4_source5, RuntimeObject* ___5_source6, ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* ___6_resultSelector, const RuntimeMethod* method) 
{
	ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* G_B6_0 = NULL;
	ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* G_B1_0 = NULL;
	ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* G_B2_0 = NULL;
	ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* G_B3_0 = NULL;
	ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* G_B4_0 = NULL;
	ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* G_B5_0 = NULL;
	int32_t G_B7_0 = 0;
	ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* G_B7_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:644>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:645>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:646>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:647>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:648>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:649>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:650>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:651>
		RuntimeObject* L_0 = ___0_source1;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B6_0 = __this;
			goto IL_0034;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_source2;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		if (L_3)
		{
			G_B6_0 = G_B1_0;
			goto IL_0034;
		}
		G_B2_0 = G_B1_0;
	}
	{
		RuntimeObject* L_4 = ___2_source3;
		bool L_5;
		L_5 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		if (L_5)
		{
			G_B6_0 = G_B2_0;
			goto IL_0034;
		}
		G_B3_0 = G_B2_0;
	}
	{
		RuntimeObject* L_6 = ___3_source4;
		bool L_7;
		L_7 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		if (L_7)
		{
			G_B6_0 = G_B3_0;
			goto IL_0034;
		}
		G_B4_0 = G_B3_0;
	}
	{
		RuntimeObject* L_8 = ___4_source5;
		bool L_9;
		L_9 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		if (L_9)
		{
			G_B6_0 = G_B4_0;
			goto IL_0034;
		}
		G_B5_0 = G_B4_0;
	}
	{
		RuntimeObject* L_10 = ___5_source6;
		bool L_11;
		L_11 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_10, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		G_B7_0 = ((int32_t)(L_11));
		G_B7_1 = G_B5_0;
		goto IL_0035;
	}

IL_0034:
	{
		G_B7_0 = 1;
		G_B7_1 = G_B6_0;
	}

IL_0035:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B7_1, (bool)G_B7_0, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:653>
		RuntimeObject* L_12 = ___0_source1;
		__this->___source1 = L_12;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source1), (void*)L_12);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:654>
		RuntimeObject* L_13 = ___1_source2;
		__this->___source2 = L_13;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source2), (void*)L_13);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:655>
		RuntimeObject* L_14 = ___2_source3;
		__this->___source3 = L_14;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source3), (void*)L_14);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:656>
		RuntimeObject* L_15 = ___3_source4;
		__this->___source4 = L_15;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source4), (void*)L_15);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:657>
		RuntimeObject* L_16 = ___4_source5;
		__this->___source5 = L_16;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source5), (void*)L_16);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:658>
		RuntimeObject* L_17 = ___5_source6;
		__this->___source6 = L_17;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source6), (void*)L_17);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:659>
		ZipLatestFunc_7_t72767CB4DE4D99C047AAFD02A6C695B26F9F3AF6* L_18 = ___6_resultSelector;
		__this->___resultSelector = L_18;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___resultSelector), (void*)L_18);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:660>
		return;
	}
}
// Method Definition Index: 81096
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestObservable_7_SubscribeCore_m499069AA93E024D7A2176DB87935F108229709AA_gshared (ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:664>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1* L_2 = (ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 17));
		((  void (*) (ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1*, int32_t, ZipLatestObservable_7_tC1A9BE55041175A094FCAACC5569DFABF216D576*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 18)))(L_2, 6, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 18));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (ZipLatest_t0F71EE796E620B2C3E270E313F06750DCE4A5AF1*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 19)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 19));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81103
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObservable_8__ctor_m62029BD4114AFD058878C6D4CCED2DA4B7669BC3_gshared (ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* __this, RuntimeObject* ___0_source1, RuntimeObject* ___1_source2, RuntimeObject* ___2_source3, RuntimeObject* ___3_source4, RuntimeObject* ___4_source5, RuntimeObject* ___5_source6, RuntimeObject* ___6_source7, ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* ___7_resultSelector, const RuntimeMethod* method) 
{
	ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* G_B7_0 = NULL;
	ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* G_B1_0 = NULL;
	ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* G_B2_0 = NULL;
	ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* G_B3_0 = NULL;
	ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* G_B4_0 = NULL;
	ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* G_B5_0 = NULL;
	ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* G_B6_0 = NULL;
	int32_t G_B8_0 = 0;
	ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* G_B8_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:748>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:749>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:750>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:751>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:752>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:753>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:754>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:755>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:756>
		RuntimeObject* L_0 = ___0_source1;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B7_0 = __this;
			goto IL_003d;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_source2;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		if (L_3)
		{
			G_B7_0 = G_B1_0;
			goto IL_003d;
		}
		G_B2_0 = G_B1_0;
	}
	{
		RuntimeObject* L_4 = ___2_source3;
		bool L_5;
		L_5 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		if (L_5)
		{
			G_B7_0 = G_B2_0;
			goto IL_003d;
		}
		G_B3_0 = G_B2_0;
	}
	{
		RuntimeObject* L_6 = ___3_source4;
		bool L_7;
		L_7 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		if (L_7)
		{
			G_B7_0 = G_B3_0;
			goto IL_003d;
		}
		G_B4_0 = G_B3_0;
	}
	{
		RuntimeObject* L_8 = ___4_source5;
		bool L_9;
		L_9 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		if (L_9)
		{
			G_B7_0 = G_B4_0;
			goto IL_003d;
		}
		G_B5_0 = G_B4_0;
	}
	{
		RuntimeObject* L_10 = ___5_source6;
		bool L_11;
		L_11 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_10, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		if (L_11)
		{
			G_B7_0 = G_B5_0;
			goto IL_003d;
		}
		G_B6_0 = G_B5_0;
	}
	{
		RuntimeObject* L_12 = ___6_source7;
		bool L_13;
		L_13 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 13)))(L_12, il2cpp_rgctx_method(method->klass->rgctx_data, 13));
		G_B8_0 = ((int32_t)(L_13));
		G_B8_1 = G_B6_0;
		goto IL_003e;
	}

IL_003d:
	{
		G_B8_0 = 1;
		G_B8_1 = G_B7_0;
	}

IL_003e:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 14)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B8_1, (bool)G_B8_0, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:758>
		RuntimeObject* L_14 = ___0_source1;
		__this->___source1 = L_14;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source1), (void*)L_14);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:759>
		RuntimeObject* L_15 = ___1_source2;
		__this->___source2 = L_15;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source2), (void*)L_15);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:760>
		RuntimeObject* L_16 = ___2_source3;
		__this->___source3 = L_16;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source3), (void*)L_16);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:761>
		RuntimeObject* L_17 = ___3_source4;
		__this->___source4 = L_17;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source4), (void*)L_17);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:762>
		RuntimeObject* L_18 = ___4_source5;
		__this->___source5 = L_18;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source5), (void*)L_18);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:763>
		RuntimeObject* L_19 = ___5_source6;
		__this->___source6 = L_19;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source6), (void*)L_19);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:764>
		RuntimeObject* L_20 = ___6_source7;
		__this->___source7 = L_20;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source7), (void*)L_20);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:765>
		ZipLatestFunc_8_t9B74703121020ED4533DFE80062E6219DAB2A795* L_21 = ___7_resultSelector;
		__this->___resultSelector = L_21;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___resultSelector), (void*)L_21);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:766>
		return;
	}
}
// Method Definition Index: 81104
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipLatestObservable_8_SubscribeCore_m08B27915A88A0679D2895556A95EEE8A05862CCB_gshared (ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:770>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D* L_2 = (ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 19));
		((  void (*) (ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D*, int32_t, ZipLatestObservable_8_tC618C793E749856B91F0DA2DC66C1F4BDCCFDBBA*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 20)))(L_2, 7, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 20));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (ZipLatest_tD87494E079B2E9E4E467DB55FA002AC3914B617D*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 21)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 21));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81067
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObserver__ctor_m17B9F0EE31EBF89953299E653D763146CC04C682_gshared (ZipLatestObserver_t4BE85AB314360398FC0402187EBCBE96BFF04C75* __this, ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* ___0_parent, int32_t ___1_index, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:310>
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2((RuntimeObject*)__this, NULL);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:312>
		ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_0 = ___0_parent;
		__this->___parent = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:313>
		int32_t L_1 = ___1_index;
		__this->___index = L_1;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:314>
		return;
	}
}
// Method Definition Index: 81068
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObserver_OnNext_mA39B5F09437A824162D7D2CAB31FA58A5829C8AF_gshared (ZipLatestObserver_t4BE85AB314360398FC0402187EBCBE96BFF04C75* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_T_tAA2081CC914903E05608BB7F99BBBD9BE786C009 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 3));
	const Il2CppFullySharedGenericAny L_8 = alloca(SizeOf_T_tAA2081CC914903E05608BB7F99BBBD9BE786C009);
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:318>
		ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_0 = __this->___parent;
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->___gate;
		V_0 = L_1;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0040:
			{
				{
					bool L_2 = V_1;
					if (!L_2)
					{
						goto IL_0049;
					}
				}
				{
					RuntimeObject* L_3 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_3, NULL);
				}

IL_0049:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_4 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_4, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:320>
			ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_5 = __this->___parent;
			NullCheck(L_5);
			__Il2CppFullySharedGenericTypeU5BU5D_tCAB6D060972DD49223A834B7EEFEB9FE2D003BEC* L_6 = L_5->___values;
			int32_t L_7 = __this->___index;
			il2cpp_codegen_memcpy(L_8, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 3)) ? ___0_value : &___0_value), SizeOf_T_tAA2081CC914903E05608BB7F99BBBD9BE786C009);
			NullCheck(L_6);
			il2cpp_codegen_memcpy((L_6)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_7)), L_8, SizeOf_T_tAA2081CC914903E05608BB7F99BBBD9BE786C009);
			Il2CppCodeGenWriteBarrierForClass(il2cpp_rgctx_data(method->klass->rgctx_data, 3), (void**)(L_6)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_7)), (void*)L_8);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:321>
			ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_9 = __this->___parent;
			int32_t L_10 = __this->___index;
			NullCheck(L_9);
			((  void (*) (ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 4)))(L_9, L_10, il2cpp_rgctx_method(method->klass->rgctx_data, 4));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:322>
			goto IL_004a;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_004a:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:323>
		return;
	}
}
// Method Definition Index: 81069
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObserver_OnError_mDA4363CA66BAABD3EE4F6DB20176701C774BA4DB_gshared (ZipLatestObserver_t4BE85AB314360398FC0402187EBCBE96BFF04C75* __this, Exception_t* ___0_ex, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:327>
		ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_0 = __this->___parent;
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->___gate;
		V_0 = L_1;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0024:
			{
				{
					bool L_2 = V_1;
					if (!L_2)
					{
						goto IL_002d;
					}
				}
				{
					RuntimeObject* L_3 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_3, NULL);
				}

IL_002d:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_4 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_4, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:329>
			ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_5 = __this->___parent;
			Exception_t* L_6 = ___0_ex;
			NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)L_5);
			VirtualActionInvoker1< Exception_t* >::Invoke(9, (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)L_5, L_6);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:330>
			goto IL_002e;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_002e:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:331>
		return;
	}
}
// Method Definition Index: 81070
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObserver_OnCompleted_mBA8807D2B0BDCC77E97F8C65456CE9BFD3BCD67A_gshared (ZipLatestObserver_t4BE85AB314360398FC0402187EBCBE96BFF04C75* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	int32_t V_3 = 0;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:335>
		ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_0 = __this->___parent;
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->___gate;
		V_0 = L_1;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0064:
			{
				{
					bool L_2 = V_1;
					if (!L_2)
					{
						goto IL_006d;
					}
				}
				{
					RuntimeObject* L_3 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_3, NULL);
				}

IL_006d:
				{
					return;
				}
			}
		});
		try
		{
			{
				RuntimeObject* L_4 = V_0;
				Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_4, (&V_1), NULL);
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:337>
				ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_5 = __this->___parent;
				NullCheck(L_5);
				BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_6 = L_5->___isCompleted;
				int32_t L_7 = __this->___index;
				NullCheck(L_6);
				(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (bool)1);
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:339>
				V_2 = (bool)1;
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:340>
				V_3 = 0;
				goto IL_0046_1;
			}

IL_002f_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:342>
				ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_8 = __this->___parent;
				NullCheck(L_8);
				BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_9 = L_8->___isCompleted;
				int32_t L_10 = V_3;
				NullCheck(L_9);
				int32_t L_11 = L_10;
				uint8_t L_12 = (uint8_t)(L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
				if (L_12)
				{
					goto IL_0042_1;
				}
			}
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:344>
				V_2 = (bool)0;
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:345>
				goto IL_0054_1;
			}

IL_0042_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:340>
				int32_t L_13 = V_3;
				V_3 = ((int32_t)il2cpp_codegen_add(L_13, 1));
			}

IL_0046_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:340>
				int32_t L_14 = V_3;
				ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_15 = __this->___parent;
				NullCheck(L_15);
				int32_t L_16 = L_15->___length;
				if ((((int32_t)L_14) < ((int32_t)L_16)))
				{
					goto IL_002f_1;
				}
			}

IL_0054_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:349>
				bool L_17 = V_2;
				if (!L_17)
				{
					goto IL_0062_1;
				}
			}
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:351>
				ZipLatest_tA7B4CF33BDA760C0855A8B0EAD654AD25E53EA4A* L_18 = __this->___parent;
				NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)L_18);
				VirtualActionInvoker0::Invoke(10, (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)L_18);
			}

IL_0062_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:353>
				goto IL_006e;
			}
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_006e:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:354>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81119
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObserver_1_get_Value_m14C2114DA94F6F627365EF253FBD6E50B65536CE_gshared (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* __this, Il2CppFullySharedGenericAny* il2cppRetVal, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_T_t5F8E0D14424E60E6596DD04CB9F9F389892824B8 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 1));
	const Il2CppFullySharedGenericAny L_0 = alloca(SizeOf_T_t5F8E0D14424E60E6596DD04CB9F9F389892824B8);
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:958>
		il2cpp_codegen_memcpy(L_0, il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),3)), SizeOf_T_t5F8E0D14424E60E6596DD04CB9F9F389892824B8);
		il2cpp_codegen_memcpy(il2cppRetVal, L_0, SizeOf_T_t5F8E0D14424E60E6596DD04CB9F9F389892824B8);
		return;
	}
}
// Method Definition Index: 81120
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObserver_1__ctor_m1D9740D97751471C1654EBF5EF1484AA5DAD9CEE_gshared (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* __this, RuntimeObject* ___0_gate, RuntimeObject* ___1_parent, int32_t ___2_index, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:960>
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2((RuntimeObject*)__this, NULL);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:962>
		RuntimeObject* L_0 = ___0_gate;
		il2cpp_codegen_write_instance_field_data<RuntimeObject*>(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0), L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:963>
		RuntimeObject* L_1 = ___1_parent;
		il2cpp_codegen_write_instance_field_data<RuntimeObject*>(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),1), L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:964>
		int32_t L_2 = ___2_index;
		il2cpp_codegen_write_instance_field_data<int32_t>(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),2), L_2);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:965>
		return;
	}
}
// Method Definition Index: 81121
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObserver_1_OnNext_mC5E5D964E8E2D4F73363969C2059CD7E2F0AE553_gshared (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IZipLatestObservable_t1DCB33AEA6D887F2440884F643B4910BB9011EE7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	const uint32_t SizeOf_T_t5F8E0D14424E60E6596DD04CB9F9F389892824B8 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 1));
	const Il2CppFullySharedGenericAny L_4 = alloca(SizeOf_T_t5F8E0D14424E60E6596DD04CB9F9F389892824B8);
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:969>
		RuntimeObject* L_0 = *(RuntimeObject**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0));
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_002b:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_0034;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_0034:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:971>
			il2cpp_codegen_memcpy(L_4, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 1)) ? ___0_value : &___0_value), SizeOf_T_t5F8E0D14424E60E6596DD04CB9F9F389892824B8);
			il2cpp_codegen_write_instance_field_data(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),3), L_4, SizeOf_T_t5F8E0D14424E60E6596DD04CB9F9F389892824B8);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:972>
			RuntimeObject* L_5 = *(RuntimeObject**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),1));
			int32_t L_6 = *(int32_t*)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),2));
			NullCheck(L_5);
			InterfaceActionInvoker1< int32_t >::Invoke(0, IZipLatestObservable_t1DCB33AEA6D887F2440884F643B4910BB9011EE7_il2cpp_TypeInfo_var, L_5, L_6);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:973>
			goto IL_0035;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0035:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:974>
		return;
	}
}
// Method Definition Index: 81122
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObserver_1_OnError_m3BEF0EF2AFE5C005497D9D051F0163DF754E04AF_gshared (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IZipLatestObservable_t1DCB33AEA6D887F2440884F643B4910BB9011EE7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:978>
		RuntimeObject* L_0 = *(RuntimeObject**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0));
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_001f:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_0028;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_0028:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:980>
			RuntimeObject* L_4 = *(RuntimeObject**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),1));
			Exception_t* L_5 = ___0_error;
			NullCheck(L_4);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, IZipLatestObservable_t1DCB33AEA6D887F2440884F643B4910BB9011EE7_il2cpp_TypeInfo_var, L_4, L_5);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:981>
			goto IL_0029;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0029:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:982>
		return;
	}
}
// Method Definition Index: 81123
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipLatestObserver_1_OnCompleted_mA0F60C8A096F27FED34337D93345CC78C366782A_gshared (ZipLatestObserver_1_t2B37D7D4B3647E0391EBC4886CB7642D03CE14C5* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IZipLatestObservable_t1DCB33AEA6D887F2440884F643B4910BB9011EE7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:986>
		RuntimeObject* L_0 = *(RuntimeObject**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),0));
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0024:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_002d;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_002d:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:988>
			RuntimeObject* L_4 = *(RuntimeObject**)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),1));
			int32_t L_5 = *(int32_t*)il2cpp_codegen_get_instance_field_data_pointer(__this, il2cpp_rgctx_field(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 0),2));
			NullCheck(L_4);
			InterfaceActionInvoker1< int32_t >::Invoke(2, IZipLatestObservable_t1DCB33AEA6D887F2440884F643B4910BB9011EE7_il2cpp_TypeInfo_var, L_4, L_5);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:989>
			goto IL_002e;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_002e:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/ZipLatest.cs:990>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80952
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObservable_1__ctor_m787E79C6081DE37EDB0A007920FBA0CF57AF8904_gshared (ZipObservable_1_tCF96E17B3CE750A3553A6CE43DA7472BC77222B2* __this, IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035* ___0_sources, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:197>
		((  void (*) (OperatorObservableBase_1_tBFE60A390AADA301289FC0A01C56C68B84E92F41*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 0)))((OperatorObservableBase_1_tBFE60A390AADA301289FC0A01C56C68B84E92F41*)__this, (bool)1, il2cpp_rgctx_method(method->klass->rgctx_data, 0));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:199>
		IObservable_1U5BU5D_tF72DA49406BA9D09C273A4691140D27CFB1F0035* L_0 = ___0_sources;
		__this->___sources = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___sources), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:200>
		return;
	}
}
// Method Definition Index: 80953
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipObservable_1_SubscribeCore_mD1C3FBE26CC66BDFD6FCEDC46CA1949176055F3D_gshared (ZipObservable_1_tCF96E17B3CE750A3553A6CE43DA7472BC77222B2* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:204>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_2 = (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 5));
		((  void (*) (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380*, ZipObservable_1_tCF96E17B3CE750A3553A6CE43DA7472BC77222B2*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))(L_2, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80935
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObservable_3__ctor_mEF14031AA312A5E3B92FBD480759347FBEC2E573_gshared (ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* __this, RuntimeObject* ___0_left, RuntimeObject* ___1_right, Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* ___2_selector, const RuntimeMethod* method) 
{
	ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* G_B2_0 = NULL;
	ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* G_B3_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:20>
		RuntimeObject* L_0 = ___0_left;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B2_0 = __this;
			goto IL_0011;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_right;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		G_B3_0 = ((int32_t)(L_3));
		G_B3_1 = G_B1_0;
		goto IL_0012;
	}

IL_0011:
	{
		G_B3_0 = 1;
		G_B3_1 = G_B2_0;
	}

IL_0012:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 4)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B3_1, (bool)G_B3_0, il2cpp_rgctx_method(method->klass->rgctx_data, 4));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:22>
		RuntimeObject* L_4 = ___0_left;
		__this->___left = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___left), (void*)L_4);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:23>
		RuntimeObject* L_5 = ___1_right;
		__this->___right = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___right), (void*)L_5);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:24>
		Func_3_t009E60D2B88B8B844FB90881977A21CC70E688A4* L_6 = ___2_selector;
		__this->___selector = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___selector), (void*)L_6);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:25>
		return;
	}
}
// Method Definition Index: 80936
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipObservable_3_SubscribeCore_m59F94EFEB3A360A5240213B094DB3FCBEA697593_gshared (ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:29>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746* L_2 = (Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 9));
		((  void (*) (Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746*, ZipObservable_3_t141F636C8E1A4B1B203F7F46E0C9055E851D7E21*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))(L_2, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (Zip_tEC0D6F6ACBBB03EB5F5910D4D8715EFFA9432746*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80965
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObservable_4__ctor_m6CD049DE72F94B8A0FBE1D94BE5C8D6B78A08A91_gshared (ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* __this, RuntimeObject* ___0_source1, RuntimeObject* ___1_source2, RuntimeObject* ___2_source3, ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* ___3_resultSelector, const RuntimeMethod* method) 
{
	ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* G_B3_0 = NULL;
	ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* G_B1_0 = NULL;
	ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* G_B2_0 = NULL;
	int32_t G_B4_0 = 0;
	ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* G_B4_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:386>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:387>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:388>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:389>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:390>
		RuntimeObject* L_0 = ___0_source1;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B3_0 = __this;
			goto IL_0019;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_source2;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		if (L_3)
		{
			G_B3_0 = G_B1_0;
			goto IL_0019;
		}
		G_B2_0 = G_B1_0;
	}
	{
		RuntimeObject* L_4 = ___2_source3;
		bool L_5;
		L_5 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		G_B4_0 = ((int32_t)(L_5));
		G_B4_1 = G_B2_0;
		goto IL_001a;
	}

IL_0019:
	{
		G_B4_0 = 1;
		G_B4_1 = G_B3_0;
	}

IL_001a:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B4_1, (bool)G_B4_0, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:392>
		RuntimeObject* L_6 = ___0_source1;
		__this->___source1 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source1), (void*)L_6);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:393>
		RuntimeObject* L_7 = ___1_source2;
		__this->___source2 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source2), (void*)L_7);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:394>
		RuntimeObject* L_8 = ___2_source3;
		__this->___source3 = L_8;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source3), (void*)L_8);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:395>
		ZipFunc_4_t73EC5A8E1464990C31A7683F4C032A54AF9E003D* L_9 = ___3_resultSelector;
		__this->___resultSelector = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___resultSelector), (void*)L_9);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:396>
		return;
	}
}
// Method Definition Index: 80966
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipObservable_4_SubscribeCore_m87872B916166C922569D7FDE93F87E1A7433D51C_gshared (ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:400>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC* L_2 = (Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 11));
		((  void (*) (Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC*, ZipObservable_4_t4CD2FE4BA9BB24EED7832CCC66EE6E8B379F27C3*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))(L_2, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (Zip_t5E758291FEC23E785A5F284CC70E8D4D8D69D5DC*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 13)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 13));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80974
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObservable_5__ctor_m56F1A44FC574943874341B5D10F48A632C348390_gshared (ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* __this, RuntimeObject* ___0_source1, RuntimeObject* ___1_source2, RuntimeObject* ___2_source3, RuntimeObject* ___3_source4, ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* ___4_resultSelector, const RuntimeMethod* method) 
{
	ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* G_B4_0 = NULL;
	ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* G_B1_0 = NULL;
	ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* G_B2_0 = NULL;
	ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* G_B3_0 = NULL;
	int32_t G_B5_0 = 0;
	ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* G_B5_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:472>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:473>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:474>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:475>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:476>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:477>
		RuntimeObject* L_0 = ___0_source1;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B4_0 = __this;
			goto IL_0022;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_source2;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		if (L_3)
		{
			G_B4_0 = G_B1_0;
			goto IL_0022;
		}
		G_B2_0 = G_B1_0;
	}
	{
		RuntimeObject* L_4 = ___2_source3;
		bool L_5;
		L_5 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		if (L_5)
		{
			G_B4_0 = G_B2_0;
			goto IL_0022;
		}
		G_B3_0 = G_B2_0;
	}
	{
		RuntimeObject* L_6 = ___3_source4;
		bool L_7;
		L_7 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		G_B5_0 = ((int32_t)(L_7));
		G_B5_1 = G_B3_0;
		goto IL_0023;
	}

IL_0022:
	{
		G_B5_0 = 1;
		G_B5_1 = G_B4_0;
	}

IL_0023:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 8)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B5_1, (bool)G_B5_0, il2cpp_rgctx_method(method->klass->rgctx_data, 8));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:479>
		RuntimeObject* L_8 = ___0_source1;
		__this->___source1 = L_8;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source1), (void*)L_8);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:480>
		RuntimeObject* L_9 = ___1_source2;
		__this->___source2 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source2), (void*)L_9);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:481>
		RuntimeObject* L_10 = ___2_source3;
		__this->___source3 = L_10;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source3), (void*)L_10);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:482>
		RuntimeObject* L_11 = ___3_source4;
		__this->___source4 = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source4), (void*)L_11);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:483>
		ZipFunc_5_tD9350842CE6F514F7DA23DF0F802D8436C843962* L_12 = ___4_resultSelector;
		__this->___resultSelector = L_12;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___resultSelector), (void*)L_12);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:484>
		return;
	}
}
// Method Definition Index: 80975
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipObservable_5_SubscribeCore_m8E95A4599694D170D7F6CC586FD03423A2179A0B_gshared (ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:488>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228* L_2 = (Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 13));
		((  void (*) (Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228*, ZipObservable_5_t2005040E13A75A66DD0306E099E0B19E266ED66A*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 14)))(L_2, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (Zip_t0FB76BF23E5D08FF8F680971B3B349BD9BE6A228*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 15)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 15));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80983
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObservable_6__ctor_m31E8FDB59552274083251C6A60132565A62602D5_gshared (ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* __this, RuntimeObject* ___0_source1, RuntimeObject* ___1_source2, RuntimeObject* ___2_source3, RuntimeObject* ___3_source4, RuntimeObject* ___4_source5, ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* ___5_resultSelector, const RuntimeMethod* method) 
{
	ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* G_B5_0 = NULL;
	ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* G_B1_0 = NULL;
	ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* G_B2_0 = NULL;
	ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* G_B3_0 = NULL;
	ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* G_B4_0 = NULL;
	int32_t G_B6_0 = 0;
	ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* G_B6_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:564>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:565>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:566>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:567>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:568>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:569>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:570>
		RuntimeObject* L_0 = ___0_source1;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B5_0 = __this;
			goto IL_002b;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_source2;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		if (L_3)
		{
			G_B5_0 = G_B1_0;
			goto IL_002b;
		}
		G_B2_0 = G_B1_0;
	}
	{
		RuntimeObject* L_4 = ___2_source3;
		bool L_5;
		L_5 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		if (L_5)
		{
			G_B5_0 = G_B2_0;
			goto IL_002b;
		}
		G_B3_0 = G_B2_0;
	}
	{
		RuntimeObject* L_6 = ___3_source4;
		bool L_7;
		L_7 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		if (L_7)
		{
			G_B5_0 = G_B3_0;
			goto IL_002b;
		}
		G_B4_0 = G_B3_0;
	}
	{
		RuntimeObject* L_8 = ___4_source5;
		bool L_9;
		L_9 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		G_B6_0 = ((int32_t)(L_9));
		G_B6_1 = G_B4_0;
		goto IL_002c;
	}

IL_002b:
	{
		G_B6_0 = 1;
		G_B6_1 = G_B5_0;
	}

IL_002c:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 10)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B6_1, (bool)G_B6_0, il2cpp_rgctx_method(method->klass->rgctx_data, 10));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:572>
		RuntimeObject* L_10 = ___0_source1;
		__this->___source1 = L_10;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source1), (void*)L_10);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:573>
		RuntimeObject* L_11 = ___1_source2;
		__this->___source2 = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source2), (void*)L_11);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:574>
		RuntimeObject* L_12 = ___2_source3;
		__this->___source3 = L_12;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source3), (void*)L_12);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:575>
		RuntimeObject* L_13 = ___3_source4;
		__this->___source4 = L_13;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source4), (void*)L_13);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:576>
		RuntimeObject* L_14 = ___4_source5;
		__this->___source5 = L_14;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source5), (void*)L_14);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:577>
		ZipFunc_6_t37AB2029351994D25D686126C972C489CA476965* L_15 = ___5_resultSelector;
		__this->___resultSelector = L_15;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___resultSelector), (void*)L_15);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:578>
		return;
	}
}
// Method Definition Index: 80984
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipObservable_6_SubscribeCore_mDF52F4BD2FED30C186853C2D03A2813B919D40E0_gshared (ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:582>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700* L_2 = (Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 15));
		((  void (*) (Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700*, ZipObservable_6_t88A94B7C80B1AD6E4619C69C8A990DCB2BEDA961*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 16)))(L_2, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 16));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (Zip_t0248CFC9AAF224BE39EA5A881E1837CDE577E700*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 17)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 17));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80992
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObservable_7__ctor_m6B492C7E060223939A84FAC052FB3DD9661A1438_gshared (ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* __this, RuntimeObject* ___0_source1, RuntimeObject* ___1_source2, RuntimeObject* ___2_source3, RuntimeObject* ___3_source4, RuntimeObject* ___4_source5, RuntimeObject* ___5_source6, ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* ___6_resultSelector, const RuntimeMethod* method) 
{
	ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* G_B6_0 = NULL;
	ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* G_B1_0 = NULL;
	ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* G_B2_0 = NULL;
	ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* G_B3_0 = NULL;
	ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* G_B4_0 = NULL;
	ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* G_B5_0 = NULL;
	int32_t G_B7_0 = 0;
	ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* G_B7_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:662>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:663>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:664>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:665>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:666>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:667>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:668>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:669>
		RuntimeObject* L_0 = ___0_source1;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B6_0 = __this;
			goto IL_0034;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_source2;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		if (L_3)
		{
			G_B6_0 = G_B1_0;
			goto IL_0034;
		}
		G_B2_0 = G_B1_0;
	}
	{
		RuntimeObject* L_4 = ___2_source3;
		bool L_5;
		L_5 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		if (L_5)
		{
			G_B6_0 = G_B2_0;
			goto IL_0034;
		}
		G_B3_0 = G_B2_0;
	}
	{
		RuntimeObject* L_6 = ___3_source4;
		bool L_7;
		L_7 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		if (L_7)
		{
			G_B6_0 = G_B3_0;
			goto IL_0034;
		}
		G_B4_0 = G_B3_0;
	}
	{
		RuntimeObject* L_8 = ___4_source5;
		bool L_9;
		L_9 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		if (L_9)
		{
			G_B6_0 = G_B4_0;
			goto IL_0034;
		}
		G_B5_0 = G_B4_0;
	}
	{
		RuntimeObject* L_10 = ___5_source6;
		bool L_11;
		L_11 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_10, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		G_B7_0 = ((int32_t)(L_11));
		G_B7_1 = G_B5_0;
		goto IL_0035;
	}

IL_0034:
	{
		G_B7_0 = 1;
		G_B7_1 = G_B6_0;
	}

IL_0035:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 12)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B7_1, (bool)G_B7_0, il2cpp_rgctx_method(method->klass->rgctx_data, 12));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:671>
		RuntimeObject* L_12 = ___0_source1;
		__this->___source1 = L_12;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source1), (void*)L_12);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:672>
		RuntimeObject* L_13 = ___1_source2;
		__this->___source2 = L_13;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source2), (void*)L_13);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:673>
		RuntimeObject* L_14 = ___2_source3;
		__this->___source3 = L_14;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source3), (void*)L_14);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:674>
		RuntimeObject* L_15 = ___3_source4;
		__this->___source4 = L_15;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source4), (void*)L_15);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:675>
		RuntimeObject* L_16 = ___4_source5;
		__this->___source5 = L_16;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source5), (void*)L_16);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:676>
		RuntimeObject* L_17 = ___5_source6;
		__this->___source6 = L_17;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source6), (void*)L_17);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:677>
		ZipFunc_7_t8AB69DDB19DFB40797AA78B99F5EA7022A9C0FF9* L_18 = ___6_resultSelector;
		__this->___resultSelector = L_18;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___resultSelector), (void*)L_18);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:678>
		return;
	}
}
// Method Definition Index: 80993
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipObservable_7_SubscribeCore_mD01D5FA24927109209668F04BA967F5517C96266_gshared (ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:682>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49* L_2 = (Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 17));
		((  void (*) (Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49*, ZipObservable_7_t52CBF792236C18D090D0BF84EEC415AAC30195C5*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 18)))(L_2, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 18));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (Zip_t7AE46385077AA6602FFDECC6F6BD99A87CA24D49*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 19)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 19));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81001
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObservable_8__ctor_mFC43AE26BE1BBA621A7D87A9058C24471179B610_gshared (ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* __this, RuntimeObject* ___0_source1, RuntimeObject* ___1_source2, RuntimeObject* ___2_source3, RuntimeObject* ___3_source4, RuntimeObject* ___4_source5, RuntimeObject* ___5_source6, RuntimeObject* ___6_source7, ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* ___7_resultSelector, const RuntimeMethod* method) 
{
	ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* G_B7_0 = NULL;
	ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* G_B1_0 = NULL;
	ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* G_B2_0 = NULL;
	ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* G_B3_0 = NULL;
	ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* G_B4_0 = NULL;
	ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* G_B5_0 = NULL;
	ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* G_B6_0 = NULL;
	int32_t G_B8_0 = 0;
	ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* G_B8_1 = NULL;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:766>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:767>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:768>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:769>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:770>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:771>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:772>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:773>
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:774>
		RuntimeObject* L_0 = ___0_source1;
		bool L_1;
		L_1 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 1)))(L_0, il2cpp_rgctx_method(method->klass->rgctx_data, 1));
		if (L_1)
		{
			G_B7_0 = __this;
			goto IL_003d;
		}
		G_B1_0 = __this;
	}
	{
		RuntimeObject* L_2 = ___1_source2;
		bool L_3;
		L_3 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 3));
		if (L_3)
		{
			G_B7_0 = G_B1_0;
			goto IL_003d;
		}
		G_B2_0 = G_B1_0;
	}
	{
		RuntimeObject* L_4 = ___2_source3;
		bool L_5;
		L_5 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)))(L_4, il2cpp_rgctx_method(method->klass->rgctx_data, 5));
		if (L_5)
		{
			G_B7_0 = G_B2_0;
			goto IL_003d;
		}
		G_B3_0 = G_B2_0;
	}
	{
		RuntimeObject* L_6 = ___3_source4;
		bool L_7;
		L_7 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 7)))(L_6, il2cpp_rgctx_method(method->klass->rgctx_data, 7));
		if (L_7)
		{
			G_B7_0 = G_B3_0;
			goto IL_003d;
		}
		G_B4_0 = G_B3_0;
	}
	{
		RuntimeObject* L_8 = ___4_source5;
		bool L_9;
		L_9 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 9)))(L_8, il2cpp_rgctx_method(method->klass->rgctx_data, 9));
		if (L_9)
		{
			G_B7_0 = G_B4_0;
			goto IL_003d;
		}
		G_B5_0 = G_B4_0;
	}
	{
		RuntimeObject* L_10 = ___5_source6;
		bool L_11;
		L_11 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(L_10, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		if (L_11)
		{
			G_B7_0 = G_B5_0;
			goto IL_003d;
		}
		G_B6_0 = G_B5_0;
	}
	{
		RuntimeObject* L_12 = ___6_source7;
		bool L_13;
		L_13 = ((  bool (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 13)))(L_12, il2cpp_rgctx_method(method->klass->rgctx_data, 13));
		G_B8_0 = ((int32_t)(L_13));
		G_B8_1 = G_B6_0;
		goto IL_003e;
	}

IL_003d:
	{
		G_B8_0 = 1;
		G_B8_1 = G_B7_0;
	}

IL_003e:
	{
		((  void (*) (OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*, bool, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 14)))((OperatorObservableBase_1_t75C9D9CF56C69ECFCA4BD13C4ACEC40AA96F33AE*)G_B8_1, (bool)G_B8_0, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:776>
		RuntimeObject* L_14 = ___0_source1;
		__this->___source1 = L_14;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source1), (void*)L_14);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:777>
		RuntimeObject* L_15 = ___1_source2;
		__this->___source2 = L_15;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source2), (void*)L_15);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:778>
		RuntimeObject* L_16 = ___2_source3;
		__this->___source3 = L_16;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source3), (void*)L_16);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:779>
		RuntimeObject* L_17 = ___3_source4;
		__this->___source4 = L_17;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source4), (void*)L_17);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:780>
		RuntimeObject* L_18 = ___4_source5;
		__this->___source5 = L_18;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source5), (void*)L_18);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:781>
		RuntimeObject* L_19 = ___5_source6;
		__this->___source6 = L_19;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source6), (void*)L_19);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:782>
		RuntimeObject* L_20 = ___6_source7;
		__this->___source7 = L_20;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___source7), (void*)L_20);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:783>
		ZipFunc_8_tEB5EFB3E758FF283028DCAC843C0E97279BE0BAC* L_21 = ___7_resultSelector;
		__this->___resultSelector = L_21;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___resultSelector), (void*)L_21);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:784>
		return;
	}
}
// Method Definition Index: 81002
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ZipObservable_8_SubscribeCore_m6CB6C6AB477704791161D82AB640E24E2BA1575A_gshared (ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4* __this, RuntimeObject* ___0_observer, RuntimeObject* ___1_cancel, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:788>
		RuntimeObject* L_0 = ___0_observer;
		RuntimeObject* L_1 = ___1_cancel;
		Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3* L_2 = (Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->klass->rgctx_data, 19));
		((  void (*) (Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3*, ZipObservable_8_t00D60DD49085B52992F70AEE912ED02F4068F8F4*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 20)))(L_2, __this, L_0, L_1, il2cpp_rgctx_method(method->klass->rgctx_data, 20));
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (Zip_tCA922D52C408257BB6E53143E7C2F12DBD0E78E3*, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 21)))(L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 21));
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 80961
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObserver__ctor_m5D420C4E6AB867D6ADE0EE24DFB486F989B467A7_gshared (ZipObserver_tEA117F108743D9CF50FE3CBC8B616BB5C58F6AA2* __this, Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* ___0_parent, int32_t ___1_index, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:323>
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2((RuntimeObject*)__this, NULL);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:325>
		Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_0 = ___0_parent;
		__this->___parent = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:326>
		int32_t L_1 = ___1_index;
		__this->___index = L_1;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:327>
		return;
	}
}
// Method Definition Index: 80962
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObserver_OnNext_m7D66CB9EDC6AE10774FC90765A515F941C20A9F5_gshared (ZipObserver_tEA117F108743D9CF50FE3CBC8B616BB5C58F6AA2* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	const uint32_t SizeOf_T_tF326E1E271571FBFF1E0F7025445396DD4EFA83B = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 3));
	const Il2CppFullySharedGenericAny L_10 = alloca(SizeOf_T_tF326E1E271571FBFF1E0F7025445396DD4EFA83B);
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:331>
		Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_0 = __this->___parent;
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->___gate;
		V_0 = L_1;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0041:
			{
				{
					bool L_2 = V_1;
					if (!L_2)
					{
						goto IL_004a;
					}
				}
				{
					RuntimeObject* L_3 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_3, NULL);
				}

IL_004a:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_4 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_4, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:333>
			Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_5 = __this->___parent;
			NullCheck(L_5);
			Queue_1U5BU5D_t344E748FB5E8ACBA415FF0FD0A1B7602A7A1DBF3* L_6 = L_5->___queues;
			int32_t L_7 = __this->___index;
			NullCheck(L_6);
			int32_t L_8 = L_7;
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
			il2cpp_codegen_memcpy(L_10, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 3)) ? ___0_value : &___0_value), SizeOf_T_tF326E1E271571FBFF1E0F7025445396DD4EFA83B);
			NullCheck(L_9);
			InvokerActionInvoker1< Il2CppFullySharedGenericAny >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 5)), il2cpp_rgctx_method(method->klass->rgctx_data, 5), L_9, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 3)) ? L_10: *(void**)L_10));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:334>
			Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_11 = __this->___parent;
			int32_t L_12 = __this->___index;
			NullCheck(L_11);
			((  void (*) (Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 6)))(L_11, L_12, il2cpp_rgctx_method(method->klass->rgctx_data, 6));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:335>
			goto IL_004b;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_004b:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:336>
		return;
	}
}
// Method Definition Index: 80963
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObserver_OnError_mCCA8BC3CFCBF4FD3B91A388E86FAAC7872C68534_gshared (ZipObserver_tEA117F108743D9CF50FE3CBC8B616BB5C58F6AA2* __this, Exception_t* ___0_ex, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:340>
		Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_0 = __this->___parent;
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->___gate;
		V_0 = L_1;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0024:
			{
				{
					bool L_2 = V_1;
					if (!L_2)
					{
						goto IL_002d;
					}
				}
				{
					RuntimeObject* L_3 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_3, NULL);
				}

IL_002d:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_4 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_4, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:342>
			Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_5 = __this->___parent;
			Exception_t* L_6 = ___0_ex;
			NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)L_5);
			VirtualActionInvoker1< Exception_t* >::Invoke(9, (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)L_5, L_6);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:343>
			goto IL_002e;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_002e:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:344>
		return;
	}
}
// Method Definition Index: 80964
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObserver_OnCompleted_m967BC83F3990C92B3DA7E8BE9EDEE1CEE4BF1447_gshared (ZipObserver_tEA117F108743D9CF50FE3CBC8B616BB5C58F6AA2* __this, const RuntimeMethod* method) 
{
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	int32_t V_3 = 0;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:348>
		Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_0 = __this->___parent;
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->___gate;
		V_0 = L_1;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0064:
			{
				{
					bool L_2 = V_1;
					if (!L_2)
					{
						goto IL_006d;
					}
				}
				{
					RuntimeObject* L_3 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_3, NULL);
				}

IL_006d:
				{
					return;
				}
			}
		});
		try
		{
			{
				RuntimeObject* L_4 = V_0;
				Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_4, (&V_1), NULL);
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:350>
				Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_5 = __this->___parent;
				NullCheck(L_5);
				BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_6 = L_5->___isDone;
				int32_t L_7 = __this->___index;
				NullCheck(L_6);
				(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (bool)1);
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:351>
				V_2 = (bool)1;
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:352>
				V_3 = 0;
				goto IL_0046_1;
			}

IL_002f_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:354>
				Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_8 = __this->___parent;
				NullCheck(L_8);
				BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_9 = L_8->___isDone;
				int32_t L_10 = V_3;
				NullCheck(L_9);
				int32_t L_11 = L_10;
				uint8_t L_12 = (uint8_t)(L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
				if (L_12)
				{
					goto IL_0042_1;
				}
			}
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:356>
				V_2 = (bool)0;
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:357>
				goto IL_0054_1;
			}

IL_0042_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:352>
				int32_t L_13 = V_3;
				V_3 = ((int32_t)il2cpp_codegen_add(L_13, 1));
			}

IL_0046_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:352>
				int32_t L_14 = V_3;
				Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_15 = __this->___parent;
				NullCheck(L_15);
				int32_t L_16 = L_15->___length;
				if ((((int32_t)L_14) < ((int32_t)L_16)))
				{
					goto IL_002f_1;
				}
			}

IL_0054_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:361>
				bool L_17 = V_2;
				if (!L_17)
				{
					goto IL_0062_1;
				}
			}
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:363>
				Zip_tFBD3EDB86B10E558E6341945D34599ECD43E4380* L_18 = __this->___parent;
				NullCheck((OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)L_18);
				VirtualActionInvoker0::Invoke(10, (OperatorObserverBase_2_tF68A0F74E245A672169076D0AEBF0DEE37E8976E*)L_18);
			}

IL_0062_1:
			{
				//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:365>
				goto IL_006e;
			}
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_006e:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:366>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Method Definition Index: 81019
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObserver_1__ctor_m65BE5D51C586C0B1B11C7A23A733BD3C18C034BF_gshared (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* __this, RuntimeObject* ___0_gate, RuntimeObject* ___1_parent, int32_t ___2_index, Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* ___3_queue, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:971>
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2((RuntimeObject*)__this, NULL);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:973>
		RuntimeObject* L_0 = ___0_gate;
		__this->___gate = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___gate), (void*)L_0);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:974>
		RuntimeObject* L_1 = ___1_parent;
		__this->___parent = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___parent), (void*)L_1);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:975>
		int32_t L_2 = ___2_index;
		__this->___index = L_2;
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:976>
		Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_3 = ___3_queue;
		__this->___queue = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___queue), (void*)L_3);
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:977>
		return;
	}
}
// Method Definition Index: 81020
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObserver_1_OnNext_m6B05FEAA1ED846F5EDD1610138EA0C7CDEFF6FBB_gshared (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* __this, Il2CppFullySharedGenericAny ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IZipObservable_t1908F5805FDF1CC2A33A432ECDEF367981470A11_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	const uint32_t SizeOf_T_t8EAD8D4396230D6607216E24CC0822944FD259E9 = il2cpp_codegen_sizeof(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 2));
	const Il2CppFullySharedGenericAny L_5 = alloca(SizeOf_T_t8EAD8D4396230D6607216E24CC0822944FD259E9);
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:981>
		RuntimeObject* L_0 = __this->___gate;
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0030:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_0039;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_0039:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:983>
			Queue_1_t00794C5F46E3254E713B03F949E6AB3A1AB1FD41* L_4 = __this->___queue;
			il2cpp_codegen_memcpy(L_5, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 2)) ? ___0_value : &___0_value), SizeOf_T_t8EAD8D4396230D6607216E24CC0822944FD259E9);
			NullCheck(L_4);
			InvokerActionInvoker1< Il2CppFullySharedGenericAny >::Invoke(il2cpp_codegen_get_direct_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 3)), il2cpp_rgctx_method(method->klass->rgctx_data, 3), L_4, (il2cpp_codegen_class_is_value_type(il2cpp_rgctx_data_no_init(method->klass->rgctx_data, 2)) ? L_5: *(void**)L_5));
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:984>
			RuntimeObject* L_6 = __this->___parent;
			int32_t L_7 = __this->___index;
			NullCheck(L_6);
			InterfaceActionInvoker1< int32_t >::Invoke(0, IZipObservable_t1908F5805FDF1CC2A33A432ECDEF367981470A11_il2cpp_TypeInfo_var, L_6, L_7);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:985>
			goto IL_003a;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_003a:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:986>
		return;
	}
}
// Method Definition Index: 81021
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObserver_1_OnError_mFD060A00828E153CBDDBEED9B3E800560EA75869_gshared (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* __this, Exception_t* ___0_error, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IZipObservable_t1908F5805FDF1CC2A33A432ECDEF367981470A11_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:990>
		RuntimeObject* L_0 = __this->___gate;
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_001f:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_0028;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_0028:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:992>
			RuntimeObject* L_4 = __this->___parent;
			Exception_t* L_5 = ___0_error;
			NullCheck(L_4);
			InterfaceActionInvoker1< Exception_t* >::Invoke(1, IZipObservable_t1908F5805FDF1CC2A33A432ECDEF367981470A11_il2cpp_TypeInfo_var, L_4, L_5);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:993>
			goto IL_0029;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0029:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:994>
		return;
	}
}
// Method Definition Index: 81022
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipObserver_1_OnCompleted_m0DC086CEA87A0300819469419C53E9CFA5413B63_gshared (ZipObserver_1_tA52AABDCF51F01F70DD0D12CFA2CE2DC93C15802* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IZipObservable_t1908F5805FDF1CC2A33A432ECDEF367981470A11_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:998>
		RuntimeObject* L_0 = __this->___gate;
		V_0 = L_0;
		V_1 = (bool)0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0024:
			{
				{
					bool L_1 = V_1;
					if (!L_1)
					{
						goto IL_002d;
					}
				}
				{
					RuntimeObject* L_2 = V_0;
					Monitor_Exit_m05B2CF037E2214B3208198C282490A2A475653FA(L_2, NULL);
				}

IL_002d:
				{
					return;
				}
			}
		});
		try
		{
			RuntimeObject* L_3 = V_0;
			Monitor_Enter_m3CDB589DA1300B513D55FDCFB52B63E879794149(L_3, (&V_1), NULL);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:1000>
			RuntimeObject* L_4 = __this->___parent;
			int32_t L_5 = __this->___index;
			NullCheck(L_4);
			InterfaceActionInvoker1< int32_t >::Invoke(2, IZipObservable_t1908F5805FDF1CC2A33A432ECDEF367981470A11_il2cpp_TypeInfo_var, L_4, L_5);
			//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:1001>
			goto IL_002e;
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_002e:
	{
		//<source_info:./Library/PackageCache/com.neuecc.unirx@31ee62cbf28c/Operators/Zip.cs:1002>
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Method Definition Index: 752
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____stringLength;
		return L_0;
	}
}
// Method Definition Index: 936
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Func_3_Invoke_mA2E67EB4D9947E4D56A2E7E2022D4A6D0BA37E90_gshared_inline (Func_3_tF03057D8F2223EA4C7E5EF1FABBE4CE367A43326* __this, RuntimeObject* ___0_arg1, int32_t ___1_arg2, const RuntimeMethod* method) 
{
	typedef bool (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, int32_t, const RuntimeMethod*);
	return ((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_arg1, ___1_arg2, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
// Method Definition Index: 55223
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_length_mCDE5BAF472BC1BEBC9D091F532AC1A07D65DB0BC_gshared_inline (WorkSlice_1_tDC724EEF28BD2F2E2B6498F1FDB285F8CCF34A44* __this, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:124>
		int32_t L_0 = __this->___m_Length;
		return L_0;
	}
}
// Method Definition Index: 55223
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_length_m7212817506EACBA1AB0D914DE401C6FA05F0DD9D_gshared_inline (WorkSlice_1_t95249C8534D20AFEA3985723537EDE6E5BF06809* __this, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:124>
		int32_t L_0 = __this->___m_Length;
		return L_0;
	}
}
// Method Definition Index: 55223
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t WorkSlice_1_get_length_m0E5769CB5B052657E7327DCAD0F2CA104327D7D8_gshared_inline (WorkSlice_1_t667B566D7F9D6CCD86634FB4157540E5A9C14E87* __this, const RuntimeMethod* method) 
{
	{
		//<source_info:./Library/PackageCache/com.unity.render-pipelines.universal@cc5029882822/Runtime/LightCookieManager.cs:124>
		int32_t L_0 = __this->___m_Length;
		return L_0;
	}
}
// Method Definition Index: 115030
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ExtractKeyDelegate_Invoke_m3214A3F92C2EB22088AB7738E8DFE1BE70925148_gshared_inline (ExtractKeyDelegate_t9BADAD4BDEEE5FEB8CBD095F1EA307C3DA921583* __this, RuntimeObject* ___0_value, const RuntimeMethod* method) 
{
	typedef String_t* (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	return ((FunctionPointerType)__this->___invoke_impl)((Il2CppObject*)__this->___method_code, ___0_value, reinterpret_cast<RuntimeMethod*>(__this->___method));
}
