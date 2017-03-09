//
//  UniqueEntity.swift
//  HistoricalCards
//
//  Created by Dmitrii on 09.03.17.
//  Copyright © 2017 Dmitrii. All rights reserved.
//

import Foundation

class UniqueEntity{
    
    // Обязательные поля Not Null
    
    public let id: Int
    public var name: String
    
    init(id: Int, name: String) {
        self.id = id
        self.name = name
    }
    
}
