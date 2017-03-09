//
//  IactionsCollecriot.swift
//  HistoricalCards
//
//  Created by Dmitrii on 09.03.17.
//  Copyright © 2017 Dmitrii. All rights reserved.
//

import Foundation


/*
 * Деяйствия над коллекцией сущностей
 */
protocol IActionsCollection : class {  // протокол только для классов
    // load
    func add<T>(item: T)
    func remove<T>(item: T)
    func removeById<T>(id: Int)
    func selectById<T>(id: Int)
}
