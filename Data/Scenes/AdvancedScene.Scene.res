<root dataType="Struct" type="Duality.Resources.Scene" id="129723834">
  <assetInfo />
  <globalGravity dataType="Struct" type="Duality.Vector2">
    <X dataType="Float">0</X>
    <Y dataType="Float">33</Y>
  </globalGravity>
  <serializeObj dataType="Array" type="Duality.GameObject[]" id="427169525">
    <item dataType="Struct" type="Duality.GameObject" id="1107383904">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="4150181478">
        <_items dataType="Array" type="Duality.Component[]" id="567845760" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="3467698836">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">1107383904</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">0</Y>
              <Z dataType="Float">-3000</Z>
            </pos>
            <posAbs dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">0</Y>
              <Z dataType="Float">-3000</Z>
            </posAbs>
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Components.Camera" id="1644659711">
            <active dataType="Bool">true</active>
            <farZ dataType="Float">10000</farZ>
            <focusDist dataType="Float">500</focusDist>
            <gameobj dataType="ObjectRef">1107383904</gameobj>
            <nearZ dataType="Float">0</nearZ>
            <passes dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="1241451995">
              <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="1890989206" length="4">
                <item dataType="Struct" type="Duality.Components.Camera+Pass" id="367116832">
                  <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba" />
                  <clearDepth dataType="Float">1</clearDepth>
                  <clearFlags dataType="Enum" type="Duality.Drawing.ClearFlag" name="All" value="3" />
                  <input />
                  <matrixMode dataType="Enum" type="Duality.Drawing.RenderMatrix" name="PerspectiveWorld" value="0" />
                  <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]" />
                  <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="AllGroups" value="2147483647" />
                </item>
                <item dataType="Struct" type="Duality.Components.Camera+Pass" id="2131221390">
                  <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba" />
                  <clearDepth dataType="Float">1</clearDepth>
                  <clearFlags dataType="Enum" type="Duality.Drawing.ClearFlag" name="None" value="0" />
                  <input />
                  <matrixMode dataType="Enum" type="Duality.Drawing.RenderMatrix" name="OrthoScreen" value="1" />
                  <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]" />
                  <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="All" value="4294967295" />
                </item>
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">2</_version>
            </passes>
            <perspective dataType="Enum" type="Duality.Drawing.PerspectiveMode" name="Parallax" value="1" />
            <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="All" value="4294967295" />
          </item>
          <item dataType="Struct" type="Duality.Components.SoundListener" id="1760865275">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">1107383904</gameobj>
          </item>
        </_items>
        <_size dataType="Int">3</_size>
        <_version dataType="Int">3</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="740528954" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="131245524">
            <item dataType="Type" id="3059840228" value="Duality.Components.Transform" />
            <item dataType="Type" id="673766934" value="Duality.Components.Camera" />
            <item dataType="Type" id="2415950560" value="Duality.Components.SoundListener" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="3108322230">
            <item dataType="ObjectRef">3467698836</item>
            <item dataType="ObjectRef">1644659711</item>
            <item dataType="ObjectRef">1760865275</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">3467698836</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="1988800752">AhiRL5B5Y06n3hQ1XFFyAQ==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">MainCamera</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="649790727">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2083362085">
        <_items dataType="Array" type="Duality.Component[]" id="3433033366" length="8">
          <item dataType="Struct" type="Duality.Components.Transform" id="3010105659">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">649790727</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3" />
            <posAbs dataType="Struct" type="Duality.Vector3" />
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="2291957295">
            <active dataType="Bool">true</active>
            <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">255</B>
              <G dataType="Byte">255</G>
              <R dataType="Byte">255</R>
            </colorTint>
            <customMat />
            <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
            <gameobj dataType="ObjectRef">649790727</gameobj>
            <offset dataType="Int">0</offset>
            <pixelGrid dataType="Bool">false</pixelGrid>
            <rect dataType="Struct" type="Duality.Rect">
              <H dataType="Float">256</H>
              <W dataType="Float">256</W>
              <X dataType="Float">-128</X>
              <Y dataType="Float">-128</Y>
            </rect>
            <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
            <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
              <contentPath dataType="String">Default:Material:DualityIcon</contentPath>
            </sharedMat>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
          <item dataType="Struct" type="MFEP.Duality.Plugins.Animation.AnimationPlayer" id="3028481768">
            <_x003C_Animation_x003E_k__BackingField dataType="Struct" type="Duality.ContentRef`1[[MFEP.Duality.Plugins.Animation.AnimResource]]">
              <contentPath dataType="String">Data\Animation Resource Samples\AdvancedSample.AdvancedSample.res</contentPath>
            </_x003C_Animation_x003E_k__BackingField>
            <_x003C_AutoPlay_x003E_k__BackingField dataType="Bool">true</_x003C_AutoPlay_x003E_k__BackingField>
            <_x003C_Looping_x003E_k__BackingField dataType="Bool">true</_x003C_Looping_x003E_k__BackingField>
            <_x003C_PlaybackRate_x003E_k__BackingField dataType="Float">1</_x003C_PlaybackRate_x003E_k__BackingField>
            <accAnimPercent dataType="Float">0</accAnimPercent>
            <active dataType="Bool">true</active>
            <animStartTime dataType="Struct" type="System.TimeSpan" />
            <gameobj dataType="ObjectRef">649790727</gameobj>
            <isPlaying dataType="Bool">false</isPlaying>
            <paused dataType="Bool">false</paused>
          </item>
          <item dataType="Struct" type="MFEP.Duality.Plugins.Animation.Extras.AnimControllerComp" id="2423657632">
            <_x003C_PauseKey_x003E_k__BackingField dataType="Enum" type="Duality.Input.Key" name="A" value="83" />
            <_x003C_StartKey_x003E_k__BackingField dataType="Enum" type="Duality.Input.Key" name="P" value="98" />
            <_x003C_StopKey_x003E_k__BackingField dataType="Enum" type="Duality.Input.Key" name="S" value="101" />
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">649790727</gameobj>
          </item>
          <item dataType="Struct" type="MFEP.Duality.Plugins.Animation.Extras.PathVisualizer" id="3374086855">
            <_x003C_BoundRadius_x003E_k__BackingField dataType="Float">0</_x003C_BoundRadius_x003E_k__BackingField>
            <_x003C_Color_x003E_k__BackingField dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">255</B>
              <G dataType="Byte">255</G>
              <R dataType="Byte">255</R>
            </_x003C_Color_x003E_k__BackingField>
            <_x003C_FollowedFrames_x003E_k__BackingField dataType="Int">300</_x003C_FollowedFrames_x003E_k__BackingField>
            <active dataType="Bool">true</active>
            <buffer dataType="Struct" type="Duality.Drawing.CanvasBuffer" id="3575919527">
              <dummy dataType="Bool">false</dummy>
              <vertexArraysFree dataType="Struct" type="System.Collections.Generic.List`1[[Duality.RawList`1[[Duality.Drawing.VertexC1P3T2]]]]" id="1253294030">
                <_items dataType="Array" type="Duality.RawList`1[[Duality.Drawing.VertexC1P3T2]][]" id="764142032" length="0" />
                <_size dataType="Int">0</_size>
                <_version dataType="Int">51</_version>
              </vertexArraysFree>
              <vertexArraysUsed dataType="Struct" type="System.Collections.Generic.List`1[[Duality.RawList`1[[Duality.Drawing.VertexC1P3T2]]]]" id="1641518410">
                <_items dataType="ObjectRef">764142032</_items>
                <_size dataType="Int">0</_size>
                <_version dataType="Int">51</_version>
              </vertexArraysUsed>
            </buffer>
            <gameobj dataType="ObjectRef">649790727</gameobj>
            <pointsFollowed dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Vector2]]" id="2264183808">
              <_items dataType="Array" type="Duality.Vector2[]" id="2664534925" length="600" />
              <_size dataType="Int">0</_size>
              <_version dataType="Int">0</_version>
            </pointsFollowed>
          </item>
        </_items>
        <_size dataType="Int">5</_size>
        <_version dataType="Int">11</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3592823144" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="1862598607">
            <item dataType="ObjectRef">3059840228</item>
            <item dataType="Type" id="567916590" value="Duality.Components.Renderers.SpriteRenderer" />
            <item dataType="Type" id="2581177546" value="MFEP.Duality.Plugins.Animation.AnimationPlayer" />
            <item dataType="Type" id="2111865246" value="MFEP.Duality.Plugins.Animation.Extras.AnimControllerComp" />
            <item dataType="Type" id="2997978330" value="MFEP.Duality.Plugins.Animation.Extras.PathVisualizer" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="310236768">
            <item dataType="ObjectRef">3010105659</item>
            <item dataType="ObjectRef">2291957295</item>
            <item dataType="ObjectRef">3028481768</item>
            <item dataType="ObjectRef">2423657632</item>
            <item dataType="ObjectRef">3374086855</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">3010105659</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="3160465437">CEQM3rfc3UG4oCTqAWuz0g==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">AnimationPlayer</name>
      <parent />
      <prefabLink />
    </item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
