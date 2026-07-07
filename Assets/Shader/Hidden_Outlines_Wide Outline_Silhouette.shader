Shader "Hidden/Outlines/Wide Outline/Silhouette" {
	Properties {
		_OutlineColor ("_OutlineColor", Vector) = (1,1,1,1)
		_Information ("_Information", Vector) = (1,1,1,1)
		[Toggle(ALPHA_CUTOUT)] _AlphaCutout ("_AlphaCutout", Float) = 0
		_AlphaCutoutTexture ("_AlphaCutoutTexture", 2D) = "white" {}
		_AlphaCutoutThreshold ("_AlphaCutoutThreshold", Float) = 0.5
		_AlphaCutoutUVTransform ("_AlphaCutoutUVTransform", Vector) = (1,1,0,0)
		[Enum(UnityEngine.Rendering.CullMode)] _Cull ("Cull", Float) = 0
		[Enum(UnityEngine.Rendering.CompareFunction)] _ZTest ("ZTest", Float) = 0
		_ZWrite ("ZWrite", Float) = 0
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