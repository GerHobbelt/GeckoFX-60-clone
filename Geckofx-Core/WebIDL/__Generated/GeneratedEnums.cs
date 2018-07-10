namespace Gecko.WebIDL
{
    using System;
    using System.ComponentModel;
    
    
    public enum AnimationPlayState
    {
        
        [Description("idle")]
        idle,
        
        [Description("pending")]
        pending,
        
        [Description("running")]
        running,
        
        [Description("paused")]
        paused,
        
        [Description("finished")]
        finished,
    }
    
    public enum FillMode
    {
        
        [Description("none")]
        none,
        
        [Description("forwards")]
        forwards,
        
        [Description("backwards")]
        backwards,
        
        [Description("both")]
        both,
        
        [Description("auto")]
        auto,
    }
    
    public enum PlaybackDirection
    {
        
        [Description("normal")]
        normal,
        
        [Description("reverse")]
        reverse,
        
        [Description("alternate")]
        alternate,
        
        [Description("alternate-reverse")]
        alternatereverse,
    }
    
    public enum ChannelCountMode
    {
        
        [Description("max")]
        max,
        
        [Description("clamped-max")]
        clampedmax,
        
        [Description("explicit")]
        @explicit,
    }
    
    public enum ChannelInterpretation
    {
        
        [Description("speakers")]
        speakers,
        
        [Description("discrete")]
        discrete,
    }
    
    public enum AudioContextState
    {
        
        [Description("suspended")]
        suspended,
        
        [Description("running")]
        running,
        
        [Description("closed")]
        closed,
    }
    
    public enum CompositeOperation
    {
        
        [Description("replace")]
        replace,
        
        [Description("add")]
        add,
        
        [Description("accumulate")]
        accumulate,
    }
    
    public enum BasicCardType
    {
        
        [Description("credit")]
        credit,
        
        [Description("debit")]
        debit,
        
        [Description("prepaid")]
        prepaid,
    }
    
    public enum BiquadFilterType
    {
        
        [Description("lowpass")]
        lowpass,
        
        [Description("highpass")]
        highpass,
        
        [Description("bandpass")]
        bandpass,
        
        [Description("lowshelf")]
        lowshelf,
        
        [Description("highshelf")]
        highshelf,
        
        [Description("peaking")]
        peaking,
        
        [Description("notch")]
        notch,
        
        [Description("allpass")]
        allpass,
    }
    
    public enum EndingTypes
    {
        
        [Description("transparent")]
        transparent,
        
        [Description("native")]
        native,
    }
    
    public enum BrowserFindCaseSensitivity
    {
        
        [Description("case-sensitive")]
        casesensitive,
        
        [Description("case-insensitive")]
        caseinsensitive,
    }
    
    public enum BrowserFindDirection
    {
        
        [Description("forward")]
        forward,
        
        [Description("backward")]
        backward,
    }
    
    public enum CacheStorageNamespace
    {
        
        [Description("content")]
        content,
        
        [Description("chrome")]
        chrome,
    }
    
    public enum CanvasWindingRule
    {
        
        [Description("nonzero")]
        nonzero,
        
        [Description("evenodd")]
        evenodd,
    }
    
    public enum CaretChangedReason
    {
        
        [Description("visibilitychange")]
        visibilitychange,
        
        [Description("updateposition")]
        updateposition,
        
        [Description("longpressonemptycontent")]
        longpressonemptycontent,
        
        [Description("taponcaret")]
        taponcaret,
        
        [Description("presscaret")]
        presscaret,
        
        [Description("releasecaret")]
        releasecaret,
        
        [Description("scroll")]
        scroll,
    }
    
    public enum CheckerboardReason
    {
        
        [Description("severe")]
        severe,
        
        [Description("recent")]
        recent,
    }
    
    public enum FrameType
    {
        
        [Description("auxiliary")]
        auxiliary,
        
        [Description("top-level")]
        toplevel,
        
        [Description("nested")]
        nested,
        
        [Description("none")]
        none,
    }
    
    public enum ClientType
    {
        
        [Description("window")]
        window,
        
        [Description("worker")]
        worker,
        
        [Description("sharedworker")]
        sharedworker,
        
        [Description("serviceworker")]
        serviceworker,
        
        [Description("all")]
        all,
    }
    
    public enum ConsoleLogLevel
    {
        
        [Description("all")]
        all,
        
        [Description("debug")]
        debug,
        
        [Description("log")]
        log,
        
        [Description("info")]
        info,
        
        [Description("clear")]
        clear,
        
        [Description("trace")]
        trace,
        
        [Description("timeEnd")]
        timeEnd,
        
        [Description("time")]
        time,
        
        [Description("group")]
        group,
        
        [Description("groupEnd")]
        groupEnd,
        
        [Description("profile")]
        profile,
        
        [Description("profileEnd")]
        profileEnd,
        
        [Description("dir")]
        dir,
        
        [Description("dirxml")]
        dirxml,
        
        [Description("warn")]
        warn,
        
        [Description("error")]
        error,
        
        [Description("off")]
        off,
    }
    
    public enum ConsoleLevel
    {
        
        [Description("log")]
        log,
        
        [Description("warning")]
        warning,
        
        [Description("error")]
        error,
    }
    
    public enum CSSTokenType
    {
        
        [Description("whitespace")]
        whitespace,
        
        [Description("comment")]
        comment,
        
        [Description("ident")]
        ident,
        
        [Description("function")]
        function,
        
        [Description("at")]
        at,
        
        [Description("id")]
        id,
        
        [Description("hash")]
        hash,
        
        [Description("number")]
        number,
        
        [Description("dimension")]
        dimension,
        
        [Description("percentage")]
        percentage,
        
        [Description("string")]
        @string,
        
        [Description("bad_string")]
        bad_string,
        
        [Description("url")]
        url,
        
        [Description("bad_url")]
        bad_url,
        
        [Description("symbol")]
        symbol,
        
        [Description("includes")]
        includes,
        
        [Description("dashmatch")]
        dashmatch,
        
        [Description("beginsmatch")]
        beginsmatch,
        
        [Description("endsmatch")]
        endsmatch,
        
        [Description("containsmatch")]
        containsmatch,
        
        [Description("urange")]
        urange,
        
        [Description("htmlcomment")]
        htmlcomment,
    }
    
    public enum CSSStyleSheetParsingMode
    {
        
        [Description("author")]
        author,
        
        [Description("user")]
        user,
        
        [Description("agent")]
        agent,
    }
    
    public enum DecoderDoctorNotificationType
    {
        
        [Description("cannot-play")]
        cannotplay,
        
        [Description("platform-decoder-not-found")]
        platformdecodernotfound,
        
        [Description("can-play-but-some-missing-decoders")]
        canplaybutsomemissingdecoders,
        
        [Description("cannot-initialize-pulseaudio")]
        cannotinitializepulseaudio,
        
        [Description("unsupported-libavcodec")]
        unsupportedlibavcodec,
        
        [Description("decode-error")]
        decodeerror,
        
        [Description("decode-warning")]
        decodewarning,
    }
    
    public enum VisibilityState
    {
        
        [Description("hidden")]
        hidden,
        
        [Description("visible")]
        visible,
    }
    
    public enum FlashClassification
    {
        
        [Description("unclassified")]
        unclassified,
        
        [Description("unknown")]
        unknown,
        
        [Description("allowed")]
        allowed,
        
        [Description("denied")]
        denied,
    }
    
    public enum SupportedType
    {
        
        [Description("text/html")]
        texthtml,
        
        [Description("text/xml")]
        textxml,
        
        [Description("application/xml")]
        applicationxml,
        
        [Description("application/xhtml+xml")]
        applicationxhtmlxml,
        
        [Description("image/svg+xml")]
        imagesvgxml,
    }
    
    public enum DOMRequestReadyState
    {
        
        [Description("pending")]
        pending,
        
        [Description("done")]
        done,
    }
    
    public enum ScrollLogicalPosition
    {
        
        [Description("start")]
        start,
        
        [Description("center")]
        center,
        
        [Description("end")]
        end,
        
        [Description("nearest")]
        nearest,
    }
    
    public enum FetchState
    {
        
        [Description("requesting")]
        requesting,
        
        [Description("responding")]
        responding,
        
        [Description("aborted")]
        aborted,
        
        [Description("errored")]
        errored,
        
        [Description("complete")]
        complete,
    }
    
    public enum FileMode
    {
        
        [Description("readonly")]
        @readonly,
        
        [Description("readwrite")]
        readwrite,
    }
    
    public enum FlexLineGrowthState
    {
        
        [Description("unchanged")]
        unchanged,
        
        [Description("shrinking")]
        shrinking,
        
        [Description("growing")]
        growing,
    }
    
    public enum FontFaceLoadStatus
    {
        
        [Description("unloaded")]
        unloaded,
        
        [Description("loading")]
        loading,
        
        [Description("loaded")]
        loaded,
        
        [Description("error")]
        error,
    }
    
    public enum FontFaceSetLoadStatus
    {
        
        [Description("loading")]
        loading,
        
        [Description("loaded")]
        loaded,
    }
    
    public enum GamepadHand
    {
        
        [Description("left")]
        left,
        
        [Description("right")]
        right,
    }
    
    public enum GamepadMappingType
    {
        
        [Description("standard")]
        standard,
    }
    
    public enum GamepadHapticActuatorType
    {
        
        [Description("vibration")]
        vibration,
    }
    
    public enum CSSBoxType
    {
        
        [Description("margin")]
        margin,
        
        [Description("border")]
        border,
        
        [Description("padding")]
        padding,
        
        [Description("content")]
        content,
    }
    
    public enum GridDeclaration
    {
        
        [Description("explicit")]
        @explicit,
        
        [Description("implicit")]
        @implicit,
    }
    
    public enum GridTrackState
    {
        
        [Description("static")]
        @static,
        
        [Description("repeat")]
        repeat,
        
        [Description("removed")]
        removed,
    }
    
    public enum ScrollRestoration
    {
        
        [Description("auto")]
        auto,
        
        [Description("manual")]
        manual,
    }
    
    public enum SelectionMode
    {
        
        [Description("select")]
        select,
        
        [Description("start")]
        start,
        
        [Description("end")]
        end,
        
        [Description("preserve")]
        preserve,
    }
    
    public enum IDBCursorDirection
    {
        
        [Description("next")]
        next,
        
        [Description("nextunique")]
        nextunique,
        
        [Description("prev")]
        prev,
        
        [Description("prevunique")]
        prevunique,
    }
    
    public enum IDBRequestReadyState
    {
        
        [Description("pending")]
        pending,
        
        [Description("done")]
        done,
    }
    
    public enum IDBTransactionMode
    {
        
        [Description("readonly")]
        @readonly,
        
        [Description("readwrite")]
        readwrite,
        
        [Description("readwriteflush")]
        readwriteflush,
        
        [Description("cleanup")]
        cleanup,
        
        [Description("versionchange")]
        versionchange,
    }
    
    public enum ImageBitmapFormat
    {
        
        [Description("RGBA32")]
        RGBA32,
        
        [Description("BGRA32")]
        BGRA32,
        
        [Description("RGB24")]
        RGB24,
        
        [Description("BGR24")]
        BGR24,
        
        [Description("GRAY8")]
        GRAY8,
        
        [Description("YUV444P")]
        YUV444P,
        
        [Description("YUV422P")]
        YUV422P,
        
        [Description("YUV420P")]
        YUV420P,
        
        [Description("YUV420SP_NV12")]
        YUV420SP_NV12,
        
        [Description("YUV420SP_NV21")]
        YUV420SP_NV21,
        
        [Description("HSV")]
        HSV,
        
        [Description("Lab")]
        Lab,
        
        [Description("DEPTH")]
        DEPTH,
    }
    
    public enum ChannelPixelLayoutDataType
    {
        
        [Description("uint8")]
        uint8,
        
        [Description("int8")]
        int8,
        
        [Description("uint16")]
        uint16,
        
        [Description("int16")]
        int16,
        
        [Description("uint32")]
        uint32,
        
        [Description("int32")]
        int32,
        
        [Description("float32")]
        float32,
        
        [Description("float64")]
        float64,
    }
    
    public enum IterationCompositeOperation
    {
        
        [Description("replace")]
        replace,
        
        [Description("accumulate")]
        accumulate,
    }
    
    public enum MediaDeviceKind
    {
        
        [Description("audioinput")]
        audioinput,
        
        [Description("audiooutput")]
        audiooutput,
        
        [Description("videoinput")]
        videoinput,
    }
    
    public enum MediaKeyMessageType
    {
        
        [Description("license-request")]
        licenserequest,
        
        [Description("license-renewal")]
        licenserenewal,
        
        [Description("license-release")]
        licenserelease,
        
        [Description("individualization-request")]
        individualizationrequest,
    }
    
    public enum MediaKeySessionType
    {
        
        [Description("temporary")]
        temporary,
        
        [Description("persistent-license")]
        persistentlicense,
    }
    
    public enum MediaKeySystemStatus
    {
        
        [Description("available")]
        available,
        
        [Description("api-disabled")]
        apidisabled,
        
        [Description("cdm-disabled")]
        cdmdisabled,
        
        [Description("cdm-not-supported")]
        cdmnotsupported,
        
        [Description("cdm-not-installed")]
        cdmnotinstalled,
        
        [Description("cdm-created")]
        cdmcreated,
    }
    
    public enum MediaKeyStatus
    {
        
        [Description("usable")]
        usable,
        
        [Description("expired")]
        expired,
        
        [Description("released")]
        released,
        
        [Description("output-restricted")]
        outputrestricted,
        
        [Description("output-downscaled")]
        outputdownscaled,
        
        [Description("status-pending")]
        statuspending,
        
        [Description("internal-error")]
        internalerror,
    }
    
    public enum MediaKeysRequirement
    {
        
        [Description("required")]
        required,
        
        [Description("optional")]
        optional,
        
        [Description("not-allowed")]
        notallowed,
    }
    
    public enum RecordingState
    {
        
        [Description("inactive")]
        inactive,
        
        [Description("recording")]
        recording,
        
        [Description("paused")]
        paused,
    }
    
    public enum MediaSourceReadyState
    {
        
        [Description("closed")]
        closed,
        
        [Description("open")]
        open,
        
        [Description("ended")]
        ended,
    }
    
    public enum MediaSourceEndOfStreamError
    {
        
        [Description("network")]
        network,
        
        [Description("decode")]
        decode,
    }
    
    public enum VideoFacingModeEnum
    {
        
        [Description("user")]
        user,
        
        [Description("environment")]
        environment,
        
        [Description("left")]
        left,
        
        [Description("right")]
        right,
    }
    
    public enum MediaSourceEnum
    {
        
        [Description("camera")]
        camera,
        
        [Description("screen")]
        screen,
        
        [Description("application")]
        application,
        
        [Description("window")]
        window,
        
        [Description("browser")]
        browser,
        
        [Description("microphone")]
        microphone,
        
        [Description("audioCapture")]
        audioCapture,
        
        [Description("other")]
        other,
    }
    
    public enum MediaStreamTrackState
    {
        
        [Description("live")]
        live,
        
        [Description("ended")]
        ended,
    }
    
    public enum MIDIPortType
    {
        
        [Description("input")]
        input,
        
        [Description("output")]
        output,
    }
    
    public enum MIDIPortDeviceState
    {
        
        [Description("disconnected")]
        disconnected,
        
        [Description("connected")]
        connected,
    }
    
    public enum MIDIPortConnectionState
    {
        
        [Description("open")]
        open,
        
        [Description("closed")]
        closed,
        
        [Description("pending")]
        pending,
    }
    
    public enum ConnectionType
    {
        
        [Description("cellular")]
        cellular,
        
        [Description("bluetooth")]
        bluetooth,
        
        [Description("ethernet")]
        ethernet,
        
        [Description("wifi")]
        wifi,
        
        [Description("other")]
        other,
        
        [Description("none")]
        none,
        
        [Description("unknown")]
        unknown,
    }
    
    public enum NotificationPermission
    {
        
        [Description("default")]
        @default,
        
        [Description("denied")]
        denied,
        
        [Description("granted")]
        granted,
    }
    
    public enum NotificationDirection
    {
        
        [Description("auto")]
        auto,
        
        [Description("ltr")]
        ltr,
        
        [Description("rtl")]
        rtl,
    }
    
    public enum OscillatorType
    {
        
        [Description("sine")]
        sine,
        
        [Description("square")]
        square,
        
        [Description("sawtooth")]
        sawtooth,
        
        [Description("triangle")]
        triangle,
        
        [Description("custom")]
        custom,
    }
    
    public enum PanningModelType
    {
        
        [Description("equalpower")]
        equalpower,
        
        [Description("HRTF")]
        HRTF,
    }
    
    public enum DistanceModelType
    {
        
        [Description("linear")]
        linear,
        
        [Description("inverse")]
        inverse,
        
        [Description("exponential")]
        exponential,
    }
    
    public enum PaymentItemType
    {
        
        [Description("tax")]
        tax,
    }
    
    public enum PaymentShippingType
    {
        
        [Description("shipping")]
        shipping,
        
        [Description("delivery")]
        delivery,
        
        [Description("pickup")]
        pickup,
    }
    
    public enum PaymentComplete
    {
        
        [Description("success")]
        success,
        
        [Description("fail")]
        fail,
        
        [Description("unknown")]
        unknown,
    }
    
    public enum PCImplSignalingState
    {
        
        [Description("SignalingInvalid")]
        SignalingInvalid,
        
        [Description("SignalingStable")]
        SignalingStable,
        
        [Description("SignalingHaveLocalOffer")]
        SignalingHaveLocalOffer,
        
        [Description("SignalingHaveRemoteOffer")]
        SignalingHaveRemoteOffer,
        
        [Description("SignalingHaveLocalPranswer")]
        SignalingHaveLocalPranswer,
        
        [Description("SignalingHaveRemotePranswer")]
        SignalingHaveRemotePranswer,
        
        [Description("SignalingClosed")]
        SignalingClosed,
    }
    
    public enum PCImplIceConnectionState
    {
        
        [Description("new")]
        @new,
        
        [Description("checking")]
        checking,
        
        [Description("connected")]
        connected,
        
        [Description("completed")]
        completed,
        
        [Description("failed")]
        failed,
        
        [Description("disconnected")]
        disconnected,
        
        [Description("closed")]
        closed,
    }
    
    public enum PCImplIceGatheringState
    {
        
        [Description("new")]
        @new,
        
        [Description("gathering")]
        gathering,
        
        [Description("complete")]
        complete,
    }
    
    public enum PCObserverStateType
    {
        
        [Description("None")]
        None,
        
        [Description("IceConnectionState")]
        IceConnectionState,
        
        [Description("IceGatheringState")]
        IceGatheringState,
        
        [Description("SignalingState")]
        SignalingState,
    }
    
    public enum NavigationType
    {
        
        [Description("navigate")]
        navigate,
        
        [Description("reload")]
        reload,
        
        [Description("back_forward")]
        back_forward,
        
        [Description("prerender")]
        prerender,
    }
    
    public enum PermissionName
    {
        
        [Description("geolocation")]
        geolocation,
        
        [Description("notifications")]
        notifications,
        
        [Description("push")]
        push,
        
        [Description("persistent-storage")]
        persistentstorage,
    }
    
    public enum PermissionState
    {
        
        [Description("granted")]
        granted,
        
        [Description("denied")]
        denied,
        
        [Description("prompt")]
        prompt,
    }
    
    public enum PresentationConnectionState
    {
        
        [Description("connecting")]
        connecting,
        
        [Description("connected")]
        connected,
        
        [Description("closed")]
        closed,
        
        [Description("terminated")]
        terminated,
    }
    
    public enum PresentationConnectionBinaryType
    {
        
        [Description("blob")]
        blob,
        
        [Description("arraybuffer")]
        arraybuffer,
    }
    
    public enum PresentationConnectionClosedReason
    {
        
        [Description("error")]
        error,
        
        [Description("closed")]
        closed,
        
        [Description("wentaway")]
        wentaway,
    }
    
    public enum ProfileTimelineMessagePortOperationType
    {
        
        [Description("serializeData")]
        serializeData,
        
        [Description("deserializeData")]
        deserializeData,
    }
    
    public enum ProfileTimelineWorkerOperationType
    {
        
        [Description("serializeDataOffMainThread")]
        serializeDataOffMainThread,
        
        [Description("serializeDataOnMainThread")]
        serializeDataOnMainThread,
        
        [Description("deserializeDataOffMainThread")]
        deserializeDataOffMainThread,
        
        [Description("deserializeDataOnMainThread")]
        deserializeDataOnMainThread,
    }
    
    public enum PushPermissionState
    {
        
        [Description("granted")]
        granted,
        
        [Description("denied")]
        denied,
        
        [Description("prompt")]
        prompt,
    }
    
    public enum PushEncryptionKeyName
    {
        
        [Description("p256dh")]
        p256dh,
        
        [Description("auth")]
        auth,
    }
    
    public enum RequestContext
    {
        
        [Description("audio")]
        audio,
        
        [Description("beacon")]
        beacon,
        
        [Description("cspreport")]
        cspreport,
        
        [Description("download")]
        download,
        
        [Description("embed")]
        embed,
        
        [Description("eventsource")]
        eventsource,
        
        [Description("favicon")]
        favicon,
        
        [Description("fetch")]
        fetch,
        
        [Description("font")]
        font,
        
        [Description("form")]
        form,
        
        [Description("frame")]
        frame,
        
        [Description("hyperlink")]
        hyperlink,
        
        [Description("iframe")]
        iframe,
        
        [Description("image")]
        image,
        
        [Description("imageset")]
        imageset,
        
        [Description("import")]
        import,
        
        [Description("internal")]
        @internal,
        
        [Description("location")]
        location,
        
        [Description("manifest")]
        manifest,
        
        [Description("object")]
        @object,
        
        [Description("ping")]
        ping,
        
        [Description("plugin")]
        plugin,
        
        [Description("prefetch")]
        prefetch,
        
        [Description("script")]
        script,
        
        [Description("sharedworker")]
        sharedworker,
        
        [Description("subresource")]
        subresource,
        
        [Description("style")]
        style,
        
        [Description("track")]
        track,
        
        [Description("video")]
        video,
        
        [Description("worker")]
        worker,
        
        [Description("xmlhttprequest")]
        xmlhttprequest,
        
        [Description("xslt")]
        xslt,
    }
    
    public enum RequestMode
    {
        
        [Description("same-origin")]
        sameorigin,
        
        [Description("no-cors")]
        nocors,
        
        [Description("cors")]
        cors,
        
        [Description("navigate")]
        navigate,
    }
    
    public enum RequestCredentials
    {
        
        [Description("omit")]
        omit,
        
        [Description("same-origin")]
        sameorigin,
        
        [Description("include")]
        include,
    }
    
    public enum RequestCache
    {
        
        [Description("default")]
        @default,
        
        [Description("no-store")]
        nostore,
        
        [Description("reload")]
        reload,
        
        [Description("no-cache")]
        nocache,
        
        [Description("force-cache")]
        forcecache,
        
        [Description("only-if-cached")]
        onlyifcached,
    }
    
    public enum RequestRedirect
    {
        
        [Description("follow")]
        follow,
        
        [Description("error")]
        error,
        
        [Description("manual")]
        manual,
    }
    
    public enum ReferrerPolicy
    {
        
        [Description("no-referrer")]
        noreferrer,
        
        [Description("no-referrer-when-downgrade")]
        noreferrerwhendowngrade,
        
        [Description("origin")]
        origin,
        
        [Description("origin-when-cross-origin")]
        originwhencrossorigin,
        
        [Description("unsafe-url")]
        unsafeurl,
        
        [Description("same-origin")]
        sameorigin,
        
        [Description("strict-origin")]
        strictorigin,
        
        [Description("strict-origin-when-cross-origin")]
        strictoriginwhencrossorigin,
    }
    
    public enum ResponseType
    {
        
        [Description("basic")]
        basic,
        
        [Description("cors")]
        cors,
        
        [Description("default")]
        @default,
        
        [Description("error")]
        error,
        
        [Description("opaque")]
        opaque,
        
        [Description("opaqueredirect")]
        opaqueredirect,
    }
    
    public enum RTCIceCredentialType
    {
        
        [Description("password")]
        password,
        
        [Description("token")]
        token,
    }
    
    public enum RTCIceTransportPolicy
    {
        
        [Description("relay")]
        relay,
        
        [Description("all")]
        all,
    }
    
    public enum RTCBundlePolicy
    {
        
        [Description("balanced")]
        balanced,
        
        [Description("max-compat")]
        maxcompat,
        
        [Description("max-bundle")]
        maxbundle,
    }
    
    public enum RTCDataChannelState
    {
        
        [Description("connecting")]
        connecting,
        
        [Description("open")]
        open,
        
        [Description("closing")]
        closing,
        
        [Description("closed")]
        closed,
    }
    
    public enum RTCDataChannelType
    {
        
        [Description("arraybuffer")]
        arraybuffer,
        
        [Description("blob")]
        blob,
    }
    
    public enum RTCSignalingState
    {
        
        [Description("stable")]
        stable,
        
        [Description("have-local-offer")]
        havelocaloffer,
        
        [Description("have-remote-offer")]
        haveremoteoffer,
        
        [Description("have-local-pranswer")]
        havelocalpranswer,
        
        [Description("have-remote-pranswer")]
        haveremotepranswer,
        
        [Description("closed")]
        closed,
    }
    
    public enum RTCIceGatheringState
    {
        
        [Description("new")]
        @new,
        
        [Description("gathering")]
        gathering,
        
        [Description("complete")]
        complete,
    }
    
    public enum RTCIceConnectionState
    {
        
        [Description("new")]
        @new,
        
        [Description("checking")]
        checking,
        
        [Description("connected")]
        connected,
        
        [Description("completed")]
        completed,
        
        [Description("failed")]
        failed,
        
        [Description("disconnected")]
        disconnected,
        
        [Description("closed")]
        closed,
    }
    
    public enum MozPacketDumpType
    {
        
        [Description("rtp")]
        rtp,
        
        [Description("srtp")]
        srtp,
        
        [Description("rtcp")]
        rtcp,
        
        [Description("srtcp")]
        srtcp,
    }
    
    public enum RTCLifecycleEvent
    {
        
        [Description("initialized")]
        initialized,
        
        [Description("icegatheringstatechange")]
        icegatheringstatechange,
        
        [Description("iceconnectionstatechange")]
        iceconnectionstatechange,
    }
    
    public enum RTCPriorityType
    {
        
        [Description("very-low")]
        verylow,
        
        [Description("low")]
        low,
        
        [Description("medium")]
        medium,
        
        [Description("high")]
        high,
    }
    
    public enum RTCDegradationPreference
    {
        
        [Description("maintain-framerate")]
        maintainframerate,
        
        [Description("maintain-resolution")]
        maintainresolution,
        
        [Description("balanced")]
        balanced,
    }
    
    public enum RTCRtpSourceEntryType
    {
        
        [Description("contributing")]
        contributing,
        
        [Description("synchronization")]
        synchronization,
    }
    
    public enum RTCRtpTransceiverDirection
    {
        
        [Description("sendrecv")]
        sendrecv,
        
        [Description("sendonly")]
        sendonly,
        
        [Description("recvonly")]
        recvonly,
        
        [Description("inactive")]
        inactive,
    }
    
    public enum RTCSdpType
    {
        
        [Description("offer")]
        offer,
        
        [Description("pranswer")]
        pranswer,
        
        [Description("answer")]
        answer,
        
        [Description("rollback")]
        rollback,
    }
    
    public enum RTCStatsType
    {
        
        [Description("inbound-rtp")]
        inboundrtp,
        
        [Description("outbound-rtp")]
        outboundrtp,
        
        [Description("csrc")]
        csrc,
        
        [Description("session")]
        session,
        
        [Description("track")]
        track,
        
        [Description("transport")]
        transport,
        
        [Description("candidate-pair")]
        candidatepair,
        
        [Description("local-candidate")]
        localcandidate,
        
        [Description("remote-candidate")]
        remotecandidate,
    }
    
    public enum RTCStatsIceCandidatePairState
    {
        
        [Description("frozen")]
        frozen,
        
        [Description("waiting")]
        waiting,
        
        [Description("inprogress")]
        inprogress,
        
        [Description("failed")]
        failed,
        
        [Description("succeeded")]
        succeeded,
        
        [Description("cancelled")]
        cancelled,
    }
    
    public enum RTCStatsIceCandidateType
    {
        
        [Description("host")]
        host,
        
        [Description("serverreflexive")]
        serverreflexive,
        
        [Description("peerreflexive")]
        peerreflexive,
        
        [Description("relayed")]
        relayed,
    }
    
    public enum OrientationType
    {
        
        [Description("portrait-primary")]
        portraitprimary,
        
        [Description("portrait-secondary")]
        portraitsecondary,
        
        [Description("landscape-primary")]
        landscapeprimary,
        
        [Description("landscape-secondary")]
        landscapesecondary,
    }
    
    public enum OrientationLockType
    {
        
        [Description("any")]
        any,
        
        [Description("natural")]
        natural,
        
        [Description("landscape")]
        landscape,
        
        [Description("portrait")]
        portrait,
        
        [Description("portrait-primary")]
        portraitprimary,
        
        [Description("portrait-secondary")]
        portraitsecondary,
        
        [Description("landscape-primary")]
        landscapeprimary,
        
        [Description("landscape-secondary")]
        landscapesecondary,
    }
    
    public enum ScrollState
    {
        
        [Description("started")]
        started,
        
        [Description("stopped")]
        stopped,
    }
    
    public enum SecurityPolicyViolationEventDisposition
    {
        
        [Description("enforce")]
        enforce,
        
        [Description("report")]
        report,
    }
    
    public enum ServiceWorkerState
    {
        
        [Description("parsed")]
        parsed,
        
        [Description("installing")]
        installing,
        
        [Description("installed")]
        installed,
        
        [Description("activating")]
        activating,
        
        [Description("activated")]
        activated,
        
        [Description("redundant")]
        redundant,
    }
    
    public enum ServiceWorkerUpdateViaCache
    {
        
        [Description("imports")]
        imports,
        
        [Description("all")]
        all,
        
        [Description("none")]
        none,
    }
    
    public enum ShadowRootMode
    {
        
        [Description("open")]
        open,
        
        [Description("closed")]
        closed,
    }
    
    public enum SocketReadyState
    {
        
        [Description("opening")]
        opening,
        
        [Description("open")]
        open,
        
        [Description("closing")]
        closing,
        
        [Description("closed")]
        closed,
        
        [Description("halfclosed")]
        halfclosed,
    }
    
    public enum SourceBufferAppendMode
    {
        
        [Description("segments")]
        segments,
        
        [Description("sequence")]
        sequence,
    }
    
    public enum SpeechRecognitionErrorCode
    {
        
        [Description("no-speech")]
        nospeech,
        
        [Description("aborted")]
        aborted,
        
        [Description("audio-capture")]
        audiocapture,
        
        [Description("network")]
        network,
        
        [Description("not-allowed")]
        notallowed,
        
        [Description("service-not-allowed")]
        servicenotallowed,
        
        [Description("bad-grammar")]
        badgrammar,
        
        [Description("language-not-supported")]
        languagenotsupported,
    }
    
    public enum SpeechSynthesisErrorCode
    {
        
        [Description("canceled")]
        canceled,
        
        [Description("interrupted")]
        interrupted,
        
        [Description("audio-busy")]
        audiobusy,
        
        [Description("audio-hardware")]
        audiohardware,
        
        [Description("network")]
        network,
        
        [Description("synthesis-unavailable")]
        synthesisunavailable,
        
        [Description("synthesis-failed")]
        synthesisfailed,
        
        [Description("language-unavailable")]
        languageunavailable,
        
        [Description("voice-unavailable")]
        voiceunavailable,
        
        [Description("text-too-long")]
        texttoolong,
        
        [Description("invalid-argument")]
        invalidargument,
    }
    
    public enum StorageType
    {
        
        [Description("persistent")]
        persistent,
        
        [Description("temporary")]
        temporary,
        
        [Description("default")]
        @default,
    }
    
    public enum StreamFilterStatus
    {
        
        [Description("uninitialized")]
        uninitialized,
        
        [Description("transferringdata")]
        transferringdata,
        
        [Description("finishedtransferringdata")]
        finishedtransferringdata,
        
        [Description("suspended")]
        suspended,
        
        [Description("closed")]
        closed,
        
        [Description("disconnected")]
        disconnected,
        
        [Description("failed")]
        failed,
    }
    
    public enum TCPSocketBinaryType
    {
        
        [Description("arraybuffer")]
        arraybuffer,
        
        [Description("string")]
        @string,
    }
    
    public enum TCPReadyState
    {
        
        [Description("connecting")]
        connecting,
        
        [Description("open")]
        open,
        
        [Description("closing")]
        closing,
        
        [Description("closed")]
        closed,
    }
    
    public enum TextTrackKind
    {
        
        [Description("subtitles")]
        subtitles,
        
        [Description("captions")]
        captions,
        
        [Description("descriptions")]
        descriptions,
        
        [Description("chapters")]
        chapters,
        
        [Description("metadata")]
        metadata,
    }
    
    public enum TextTrackMode
    {
        
        [Description("disabled")]
        disabled,
        
        [Description("hidden")]
        hidden,
        
        [Description("showing")]
        showing,
    }
    
    public enum Transport
    {
        
        [Description("bt")]
        bt,
        
        [Description("ble")]
        ble,
        
        [Description("nfc")]
        nfc,
        
        [Description("usb")]
        usb,
    }
    
    public enum VREye
    {
        
        [Description("left")]
        left,
        
        [Description("right")]
        right,
    }
    
    public enum VRDisplayEventReason
    {
        
        [Description("mounted")]
        mounted,
        
        [Description("navigation")]
        navigation,
        
        [Description("requested")]
        requested,
        
        [Description("unmounted")]
        unmounted,
    }
    
    public enum AutoKeyword
    {
        
        [Description("auto")]
        auto,
    }
    
    public enum LineAlignSetting
    {
        
        [Description("start")]
        start,
        
        [Description("center")]
        center,
        
        [Description("end")]
        end,
    }
    
    public enum PositionAlignSetting
    {
        
        [Description("line-left")]
        lineleft,
        
        [Description("center")]
        center,
        
        [Description("line-right")]
        lineright,
        
        [Description("auto")]
        auto,
    }
    
    public enum AlignSetting
    {
        
        [Description("start")]
        start,
        
        [Description("center")]
        center,
        
        [Description("end")]
        end,
        
        [Description("left")]
        left,
        
        [Description("right")]
        right,
    }
    
    public enum DirectionSetting
    {
        
        [Description("rl")]
        rl,
        
        [Description("lr")]
        lr,
    }
    
    public enum ScrollSetting
    {
        
        [Description("up")]
        up,
    }
    
    public enum OverSampleType
    {
        
        [Description("none")]
        none,
        
        [Description("2x")]
        _2x,
        
        [Description("4x")]
        _4x,
    }
    
    public enum AuthenticatorAttachment
    {
        
        [Description("platform")]
        platform,
        
        [Description("cross-platform")]
        crossplatform,
    }
    
    public enum AttestationConveyancePreference
    {
        
        [Description("none")]
        none,
        
        [Description("indirect")]
        indirect,
        
        [Description("direct")]
        direct,
    }
    
    public enum UserVerificationRequirement
    {
        
        [Description("required")]
        required,
        
        [Description("preferred")]
        preferred,
        
        [Description("discouraged")]
        discouraged,
    }
    
    public enum PublicKeyCredentialType
    {
        
        [Description("public-key")]
        publickey,
    }
    
    public enum AuthenticatorTransport
    {
        
        [Description("usb")]
        usb,
        
        [Description("nfc")]
        nfc,
        
        [Description("ble")]
        ble,
    }
    
    public enum BinaryType
    {
        
        [Description("blob")]
        blob,
        
        [Description("arraybuffer")]
        arraybuffer,
    }
    
    public enum ScrollBehavior
    {
        
        [Description("auto")]
        auto,
        
        [Description("instant")]
        instant,
        
        [Description("smooth")]
        smooth,
    }
    
    public enum XMLHttpRequestResponseType
    {
        
        [Description("arraybuffer")]
        arraybuffer,
        
        [Description("blob")]
        blob,
        
        [Description("document")]
        document,
        
        [Description("json")]
        json,
        
        [Description("text")]
        text,
        
        [Description("moz-chunked-arraybuffer")]
        mozchunkedarraybuffer,
    }
}
