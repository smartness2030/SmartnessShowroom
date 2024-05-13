//Shader taken from https://assetstore.unity.com/packages/tools/utilities/point-cloud-free-viewer-19811#description
Shader "Custom/VertexColor" {

	Properties{
        _Color("Tint", Color) = (1,1,1,1)
    }

    SubShader {
    Pass {
        LOD 200
              
                 
        CGPROGRAM
        #pragma vertex vert
        #pragma fragment frag
  
        struct VertexInput {
            float4 v : POSITION;
            float4 color: COLOR;
        };
         
        struct VertexOutput {
            float4 pos : SV_POSITION;
            float4 col : COLOR;
        };
		
		fixed4 _Color;
         
        VertexOutput vert(VertexInput v) {
         
            VertexOutput o;
            o.pos = UnityObjectToClipPos(v.v);
            o.col = v.color * _Color ;
             
            return o;
        }
         
        float4 frag(VertexOutput o) : COLOR {
            return o.col;
        }
 
        ENDCG
        } 
    } 
}
