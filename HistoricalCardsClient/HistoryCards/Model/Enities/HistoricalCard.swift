//
//  HistoricalCard.swift
//  HistoricalCards
//
//  Created by Dmitrii on 08.03.17.
//  Copyright © 2017 Dmitrii. All rights reserved.
//

import Foundation

final class HistoricalCard : UniqueEntity{

    var fromDatetime: Date
    
    // Необязательные поля Null
    var discription: String?
    
    init(id: Int, name: String, fromDatetime: Date) {
        self.fromDatetime = fromDatetime
        super.init(id: id, name: name)
    }
    
    convenience init(id: Int, name: String, fromDatetime: Date, discription: String){
        self.init(id: id, name: name, fromDatetime: fromDatetime)
        self.discription = discription
    }
}


// MARK: Функционал класса

extension HistoricalCard{


}
