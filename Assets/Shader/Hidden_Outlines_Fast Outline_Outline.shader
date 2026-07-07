Shader "Hidden/Outlines/Fast Outline/Outline" {
	Properties {
		_OutlineColor ("Outline Color", Vector) = (0,1,0,1)
		_OutlineOccludedColor ("Outline Occluded Color", Vector) = (1,0,0,1)
		_OutlineWidth ("Outline Width", Range(0, 1)) = 0.5
		_MinimumOutlineWidth ("Minimum Outline Width", Range(0, 1)) = 0.5
		[Toggle(SCALE_WITH_RESOLUTION)] _ResolutionDependent ("Resolution Dependent", Float) = 0
		_ReferenceResolution ("Reference Resolution", Float) = 1080
		_SrcBlend ("_SrcBlend", Float) = 0
		_DstBlend ("_DstBlend", Float) = 0
		[Enum(UnityEngine.Rendering.CullMode)] _Cull ("Cull", Float) = 0
		[Enum(UnityEngine.Rendering.CompareFunction)] _ZTest ("ZTest", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
}