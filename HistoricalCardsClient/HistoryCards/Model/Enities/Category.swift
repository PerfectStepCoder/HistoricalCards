//
//  Category.swift
//  HistoricalCards
//
//  Created by Dmitrii on 08.03.17.
//  Copyright © 2017 Dmitrii. All rights reserved.
//

import Foundation

final class Category : UniqueEntity{
    
    var parentId: Int
    
    // Необязательные поля Null
    var discription: String?
    
    init(id: Int, name: String, parentId: Int) {
        self.parentId = parentId
        super.init(id: id, name: name)
    }
    
    convenience init(id: Int, name: String, fromDatetime: Date, discription: String){
        self.init(id: id, name: name, fromDatetime: fromDatetime)
        self.discription = discription
    }
}
