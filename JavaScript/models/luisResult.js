/*
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

const models = require('./index');

/**
 * Class representing a LuisResult.
 */
class LuisResult {
  /**
   * Create a LuisResult.
   * @member {string} [query]
   * @member {object} [topScoringIntent]
   * @member {string} [topScoringIntent.intent]
   * @member {number} [topScoringIntent.score]
   * @member {array} [intents]
   * @member {array} [entities]
   * @member {array} [compositeEntities] The composite entities extracted from
   * the utterance.
   */
  constructor() {
  }

  /**
   * Defines the metadata of LuisResult
   *
   * @returns {object} metadata of LuisResult
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'LuisResult',
      type: {
        name: 'Composite',
        className: 'LuisResult',
        modelProperties: {
          query: {
            required: false,
            serializedName: 'query',
            type: {
              name: 'String'
            }
          },
          topScoringIntent: {
            required: false,
            serializedName: 'topScoringIntent',
            type: {
              name: 'Composite',
              className: 'IntentModel'
            }
          },
          intents: {
            required: false,
            serializedName: 'intents',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'IntentModelElementType',
                  type: {
                    name: 'Composite',
                    className: 'IntentModel'
                  }
              }
            }
          },
          entities: {
            required: false,
            serializedName: 'entities',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'EntityModelElementType',
                  type: {
                    name: 'Composite',
                    className: 'EntityModel'
                  }
              }
            }
          },
          compositeEntities: {
            required: false,
            serializedName: 'compositeEntities',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'CompositeEntityModelElementType',
                  type: {
                    name: 'Composite',
                    className: 'CompositeEntityModel'
                  }
              }
            }
          }
        }
      }
    };
  }
}

module.exports = LuisResult;
