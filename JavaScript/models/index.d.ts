/*
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import * as moment from "moment";


/**
 * @class
 * Initializes a new instance of the IntentModel class.
 * @constructor
 * Intent returned from LUIS.
 *
 * @member {string} [intent]
 * @member {number} [score]
 */
export interface IntentModel {
  intent?: string;
  score?: number;
}

/**
 * @class
 * Initializes a new instance of the EntityModel class.
 * @constructor
 * Entity returned from LUIS.
 *
 * @member {object} [additionalProperties] Unmatched properties from the
 * message are deserialized this collection
 * @member {string} entity
 * @member {string} type
 * @member {number} startIndex
 * @member {number} endIndex
 */
export interface EntityModel {
  additionalProperties?: { [propertyName: string]: any };
  entity: string;
  type: string;
  startIndex: number;
  endIndex: number;
}

/**
 * @class
 * Initializes a new instance of the CompositeChildModel class.
 * @constructor
 * Child entity in LUIS composite entity.
 *
 * @member {string} type Type of child entity.
 * @member {string} value Value extracted by LUIS.
 */
export interface CompositeChildModel {
  type: string;
  value: string;
}

/**
 * @class
 * Initializes a new instance of the CompositeEntityModel class.
 * @constructor
 * LUIS Composite Entity.
 *
 * @member {string} parentType Type/name of parent entity.
 * @member {string} value Value for composite entity extracted by LUIS.
 * @member {array} children
 */
export interface CompositeEntityModel {
  parentType: string;
  value: string;
  children: CompositeChildModel[];
}

/**
 * @class
 * Initializes a new instance of the LuisResult class.
 * @constructor
 * @member {string} [query]
 * @member {object} [topScoringIntent]
 * @member {string} [topScoringIntent.intent]
 * @member {number} [topScoringIntent.score]
 * @member {array} [intents]
 * @member {array} [entities]
 * @member {array} [compositeEntities] The composite entities extracted from
 * the utterance.
 */
export interface LuisResult {
  query?: string;
  topScoringIntent?: IntentModel;
  intents?: IntentModel[];
  entities?: EntityModel[];
  compositeEntities?: CompositeEntityModel[];
}

/**
 * @class
 * Initializes a new instance of the EntityWithScore class.
 * @constructor
 * @member {number} [score]
 */
export interface EntityWithScore extends EntityModel {
  score?: number;
}

/**
 * @class
 * Initializes a new instance of the EntityWithResolution class.
 * @constructor
 * @member {object} [resolution]
 */
export interface EntityWithResolution extends EntityModel {
  resolution?: any;
}
