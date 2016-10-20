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
        <_items dataType="Array" type="Duality.Component[]" id="567845760">
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
              <Z dataType="Float">-500</Z>
            </pos>
            <posAbs dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">0</Y>
              <Z dataType="Float">-500</Z>
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
          <item dataType="Struct" type="MFEP.Duality.Plugins.Animation.AnimationPlayer" id="3486074945">
            <_x003C_AutoPlay_x003E_k__BackingField dataType="Bool">false</_x003C_AutoPlay_x003E_k__BackingField>
            <_x003C_Looping_x003E_k__BackingField dataType="Bool">false</_x003C_Looping_x003E_k__BackingField>
            <_x003C_Percent_x003E_k__BackingField dataType="Float">0</_x003C_Percent_x003E_k__BackingField>
            <_x003C_PlaybackRate_x003E_k__BackingField dataType="Float">1</_x003C_PlaybackRate_x003E_k__BackingField>
            <accAnimPercent dataType="Float">0</accAnimPercent>
            <active dataType="Bool">true</active>
            <animation dataType="Struct" type="Duality.ContentRef`1[[MFEP.Duality.Plugins.Animation.AnimResource]]">
              <contentPath dataType="String">Data\Animation Resource Samples\RealWorldExample\ScreenShakeRes.ScreenShakeRes.res</contentPath>
            </animation>
            <animStartTime dataType="Struct" type="System.TimeSpan" />
            <gameobj dataType="ObjectRef">1107383904</gameobj>
            <state dataType="Enum" type="MFEP.Duality.Plugins.Animation.AnimationPlayer+State" name="Stopped" value="1" />
          </item>
        </_items>
        <_size dataType="Int">4</_size>
        <_version dataType="Int">4</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="740528954" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="131245524">
            <item dataType="Type" id="3059840228" value="Duality.Components.Transform" />
            <item dataType="Type" id="673766934" value="Duality.Components.Camera" />
            <item dataType="Type" id="2415950560" value="Duality.Components.SoundListener" />
            <item dataType="Type" id="1309006434" value="MFEP.Duality.Plugins.Animation.AnimationPlayer" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="3108322230">
            <item dataType="ObjectRef">3467698836</item>
            <item dataType="ObjectRef">1644659711</item>
            <item dataType="ObjectRef">1760865275</item>
            <item dataType="ObjectRef">3486074945</item>
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
            <pos dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">223.999954</X>
              <Y dataType="Float">-160</Y>
              <Z dataType="Float">0</Z>
            </pos>
            <posAbs dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">223.999954</X>
              <Y dataType="Float">-160</Y>
              <Z dataType="Float">0</Z>
            </posAbs>
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
              <H dataType="Float">64</H>
              <W dataType="Float">64</W>
              <X dataType="Float">-32</X>
              <Y dataType="Float">-32</Y>
            </rect>
            <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
            <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
              <contentPath dataType="String">Default:Material:DualityIcon</contentPath>
            </sharedMat>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
          <item dataType="Struct" type="MFEP.Duality.Plugins.Animation.AnimationPlayer" id="3028481768">
            <_x003C_AutoPlay_x003E_k__BackingField dataType="Bool">false</_x003C_AutoPlay_x003E_k__BackingField>
            <_x003C_Looping_x003E_k__BackingField dataType="Bool">false</_x003C_Looping_x003E_k__BackingField>
            <_x003C_Percent_x003E_k__BackingField dataType="Float">1</_x003C_Percent_x003E_k__BackingField>
            <_x003C_PlaybackRate_x003E_k__BackingField dataType="Float">1</_x003C_PlaybackRate_x003E_k__BackingField>
            <accAnimPercent dataType="Float">1.06638682</accAnimPercent>
            <active dataType="Bool">true</active>
            <animation dataType="Struct" type="Duality.ContentRef`1[[MFEP.Duality.Plugins.Animation.AnimResource]]">
              <contentPath dataType="String">Data\Animation Resource Samples\RealWorldExample\StepRight.StepRight.res</contentPath>
            </animation>
            <animStartTime dataType="Struct" type="System.TimeSpan">
              <_ticks dataType="Long">367745962</_ticks>
            </animStartTime>
            <gameobj dataType="ObjectRef">649790727</gameobj>
            <state dataType="Enum" type="MFEP.Duality.Plugins.Animation.AnimationPlayer+State" name="Paused" value="2" />
          </item>
          <item dataType="Struct" type="MFEP.Duality.Plugins.Animation.Sample.StepCmp" id="1041513377">
            <_x003C_StepDownRes_x003E_k__BackingField dataType="Struct" type="Duality.ContentRef`1[[MFEP.Duality.Plugins.Animation.AnimResource]]">
              <contentPath dataType="String">Data\Animation Resource Samples\RealWorldExample\StepDown.StepDown.res</contentPath>
            </_x003C_StepDownRes_x003E_k__BackingField>
            <_x003C_StepLeftRes_x003E_k__BackingField dataType="Struct" type="Duality.ContentRef`1[[MFEP.Duality.Plugins.Animation.AnimResource]]">
              <contentPath dataType="String">Data\Animation Resource Samples\RealWorldExample\StepLeft.StepLeft.res</contentPath>
            </_x003C_StepLeftRes_x003E_k__BackingField>
            <_x003C_StepRightRes_x003E_k__BackingField dataType="Struct" type="Duality.ContentRef`1[[MFEP.Duality.Plugins.Animation.AnimResource]]">
              <contentPath dataType="String">Data\Animation Resource Samples\RealWorldExample\StepRight.StepRight.res</contentPath>
            </_x003C_StepRightRes_x003E_k__BackingField>
            <_x003C_StepUpRes_x003E_k__BackingField dataType="Struct" type="Duality.ContentRef`1[[MFEP.Duality.Plugins.Animation.AnimResource]]">
              <contentPath dataType="String">Data\Animation Resource Samples\RealWorldExample\StepUp.StepUp.res</contentPath>
            </_x003C_StepUpRes_x003E_k__BackingField>
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">649790727</gameobj>
          </item>
          <item dataType="Struct" type="MFEP.Duality.Plugins.Animation.Sample.ExampleController" id="1463579921">
            <_x003C_ScreenShakeAnimationPlayer_x003E_k__BackingField dataType="ObjectRef">3486074945</_x003C_ScreenShakeAnimationPlayer_x003E_k__BackingField>
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">649790727</gameobj>
          </item>
        </_items>
        <_size dataType="Int">5</_size>
        <_version dataType="Int">15</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3592823144" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="1862598607">
            <item dataType="ObjectRef">3059840228</item>
            <item dataType="Type" id="567916590" value="Duality.Components.Renderers.SpriteRenderer" />
            <item dataType="ObjectRef">1309006434</item>
            <item dataType="Type" id="2581177546" value="MFEP.Duality.Plugins.Animation.Sample.StepCmp" />
            <item dataType="Type" id="2111865246" value="MFEP.Duality.Plugins.Animation.Sample.ExampleController" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="310236768">
            <item dataType="ObjectRef">3010105659</item>
            <item dataType="ObjectRef">2291957295</item>
            <item dataType="ObjectRef">3028481768</item>
            <item dataType="ObjectRef">1041513377</item>
            <item dataType="ObjectRef">1463579921</item>
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
    <item dataType="Struct" type="Duality.GameObject" id="2636419884">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="4088862050">
        <_items dataType="Array" type="Duality.Component[]" id="2328134544" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="701767520">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">2636419884</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3" />
            <posAbs dataType="Struct" type="Duality.Vector3" />
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="4278586452">
            <active dataType="Bool">true</active>
            <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">255</B>
              <G dataType="Byte">255</G>
              <R dataType="Byte">255</R>
            </colorTint>
            <customMat />
            <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
            <gameobj dataType="ObjectRef">2636419884</gameobj>
            <offset dataType="Int">0</offset>
            <pixelGrid dataType="Bool">false</pixelGrid>
            <rect dataType="Struct" type="Duality.Rect">
              <H dataType="Float">1024</H>
              <W dataType="Float">1024</W>
              <X dataType="Float">-512</X>
              <Y dataType="Float">-512</Y>
            </rect>
            <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
            <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
              <contentPath dataType="String">Default:Material:Checkerboard</contentPath>
            </sharedMat>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">2</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="873891210" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="1876901880">
            <item dataType="ObjectRef">3059840228</item>
            <item dataType="ObjectRef">567916590</item>
          </keys>
          <values dataType="Array" type="System.Object[]" id="2383679966">
            <item dataType="ObjectRef">701767520</item>
            <item dataType="ObjectRef">4278586452</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">701767520</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="108928164">hNBifka0gEOv2FeEol/BKA==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">Checker</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="546596830">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2096204744">
        <_items dataType="Array" type="Duality.Component[]" id="940034668" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="2906911762">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">546596830</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3" />
            <posAbs dataType="Struct" type="Duality.Vector3" />
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Components.Renderers.TextRenderer" id="2289225652">
            <active dataType="Bool">true</active>
            <blockAlign dataType="Enum" type="Duality.Alignment" name="Center" value="0" />
            <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">255</B>
              <G dataType="Byte">255</G>
              <R dataType="Byte">255</R>
            </colorTint>
            <customMat />
            <gameobj dataType="ObjectRef">546596830</gameobj>
            <iconMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]" />
            <offset dataType="Int">0</offset>
            <text dataType="Struct" type="Duality.Drawing.FormattedText" id="1318836244">
              <flowAreas />
              <fonts dataType="Array" type="Duality.ContentRef`1[[Duality.Resources.Font]][]" id="1325325924">
                <item dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Font]]">
                  <contentPath dataType="String">Default:Font:GenericMonospace10</contentPath>
                </item>
              </fonts>
              <icons />
              <lineAlign dataType="Enum" type="Duality.Alignment" name="Left" value="1" />
              <maxHeight dataType="Int">0</maxHeight>
              <maxWidth dataType="Int">0</maxWidth>
              <sourceText dataType="String">Movement: &lt;arrow keys&gt;</sourceText>
              <wrapMode dataType="Enum" type="Duality.Drawing.FormattedText+WrapMode" name="Word" value="1" />
            </text>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">2</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3019330270" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="3313173642">
            <item dataType="ObjectRef">3059840228</item>
            <item dataType="Type" id="1896317920" value="Duality.Components.Renderers.TextRenderer" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="749679898">
            <item dataType="ObjectRef">2906911762</item>
            <item dataType="ObjectRef">2289225652</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">2906911762</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="901215594">iCqAABTNxU24sO1Yw5KDkw==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">TextRenderer</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="465696557">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1862610463">
        <_items dataType="Array" type="Duality.Component[]" id="577565038" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="2826011489">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">465696557</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3" />
            <posAbs dataType="Struct" type="Duality.Vector3" />
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="2107863125">
            <active dataType="Bool">true</active>
            <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">255</B>
              <G dataType="Byte">255</G>
              <R dataType="Byte">255</R>
            </colorTint>
            <customMat />
            <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
            <gameobj dataType="ObjectRef">465696557</gameobj>
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
              <contentPath dataType="String">Default:Material:SolidBlack</contentPath>
            </sharedMat>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">2</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2862876704" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="3100363157">
            <item dataType="ObjectRef">3059840228</item>
            <item dataType="ObjectRef">567916590</item>
          </keys>
          <values dataType="Array" type="System.Object[]" id="2802189512">
            <item dataType="ObjectRef">2826011489</item>
            <item dataType="ObjectRef">2107863125</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">2826011489</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="3443541151">sbB0JbVQaUeMVm6UUVFi9Q==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">TextBackground</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="1234223145">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2913844395">
        <_items dataType="Array" type="Duality.Component[]" id="450023670" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="3594538077">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">1234223145</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">-1</X>
              <Y dataType="Float">34</Y>
              <Z dataType="Float">0</Z>
            </pos>
            <posAbs dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">-1</X>
              <Y dataType="Float">34</Y>
              <Z dataType="Float">0</Z>
            </posAbs>
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Components.Renderers.TextRenderer" id="2976851967">
            <active dataType="Bool">true</active>
            <blockAlign dataType="Enum" type="Duality.Alignment" name="Center" value="0" />
            <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">255</B>
              <G dataType="Byte">255</G>
              <R dataType="Byte">255</R>
            </colorTint>
            <customMat />
            <gameobj dataType="ObjectRef">1234223145</gameobj>
            <iconMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]" />
            <offset dataType="Int">0</offset>
            <text dataType="Struct" type="Duality.Drawing.FormattedText" id="3295363103">
              <flowAreas />
              <fonts dataType="Array" type="Duality.ContentRef`1[[Duality.Resources.Font]][]" id="1597823342">
                <item dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Font]]">
                  <contentPath dataType="String">Default:Font:GenericMonospace10</contentPath>
                </item>
              </fonts>
              <icons />
              <lineAlign dataType="Enum" type="Duality.Alignment" name="Left" value="1" />
              <maxHeight dataType="Int">0</maxHeight>
              <maxWidth dataType="Int">0</maxWidth>
              <sourceText dataType="String">Screen shake: &lt;space bar&gt;</sourceText>
              <wrapMode dataType="Enum" type="Duality.Drawing.FormattedText+WrapMode" name="Word" value="1" />
            </text>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">2</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2260119880" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="2642659201">
            <item dataType="ObjectRef">3059840228</item>
            <item dataType="ObjectRef">1896317920</item>
          </keys>
          <values dataType="Array" type="System.Object[]" id="3101159776">
            <item dataType="ObjectRef">3594538077</item>
            <item dataType="ObjectRef">2976851967</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">3594538077</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="2525010131">DYlow/jf6EmNiFX2ikyhzA==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">TextRenderer</name>
      <parent />
      <prefabLink />
    </item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
