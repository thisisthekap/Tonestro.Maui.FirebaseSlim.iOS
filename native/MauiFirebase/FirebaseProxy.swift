//
//  FirebaseProxy.swift
//  MauiFirebase
//
//  Created by Christian Kapplmüller on 24.06.24.
//

import Foundation
import UIKit
import FirebaseAnalytics
import FirebaseCore

@objc(FirebaseCoreSlim)
public class FirebaseCoreSlim: NSObject {
    @objc
    public static let shared  = FirebaseCoreSlim()
    
    @objc
    public func configure() {
        FirebaseApp.configure()
    }
}

@objc(AnalyticsManagerSlim)
public class AnalyticsManagerSlim : NSObject {
    
    @objc
    public static let shared = AnalyticsManagerSlim()
    
    @objc
    public func logEvent(_ name: String, parameters: [String: Any]) {
        Analytics.logEvent(name, parameters: parameters)
    }
    
    @objc
    public var appInstanceId: String {
        return Analytics.appInstanceID() ?? ""
    }
    
    @objc
    public func setUserId(_ userId: String?) {
        Analytics.setUserID(userId)
    }
    
    @objc
    public func setUserProperty(_ value: String?, forName name: String) {
        Analytics.setUserProperty(value, forName: name)
    }
}
