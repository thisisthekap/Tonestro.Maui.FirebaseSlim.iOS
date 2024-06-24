#!/bin/bash
dotnet build
sharpie bind -framework ../native/bin/Release/net8.0-ios/MauiFirebase-iOS/MauiFirebase-iOS.xcframework/ios-arm64/MauiFirebase.framework -namespace Tonestro.Maui.FirebaseSlim.iOS
mv ApiDefinitions.cs Apidefinition.cs
