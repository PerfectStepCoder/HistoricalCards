//
//  IntarfaceCRUD.swift
//  HistoricalCards
//
//  Created by Dmitrii on 09.03.17.
//  Copyright © 2017 Dmitrii. All rights reserved.
//

import Foundation

/*
 * Персистентность коллекции в базу данных
 */
protocol ICRUD : class {  // протокол только для классов
    // load
    func load<T>() -> T
    func create<T>(entity: T)
    func delete<T>(entity: T)
    func update<T>(entity: T)
    func save<T>(entity: T)
}
