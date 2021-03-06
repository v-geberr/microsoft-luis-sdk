/*
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

const models = require('./index');

/**
 * Class representing a EntityWithResolution.
 * @extends models['EntityModel']
 */
class EntityWithResolution extends models['EntityModel'] {
  /**
   * Create a EntityWithResolution.
   * @member {object} [resolution]
   */
  constructor() {
    super();
  }

  /**
   * Defines the metadata of EntityWithResolution
   *
   * @returns {object} metadata of EntityWithResolution
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'EntityWithResolution',
      type: {
        name: 'Composite',
        className: 'EntityWithResolution',
        modelProperties: {
          additionalProperties: {
            required: false,
            type: {
              name: 'Dictionary',
              value: {
                  required: false,
                  serializedName: 'ObjectElementType',
                  type: {
                    name: 'Object'
                  }
              }
            }
          },
          entity: {
            required: true,
            serializedName: 'entity',
            type: {
              name: 'String'
            }
          },
          type: {
            required: true,
            serializedName: 'type',
            type: {
              name: 'String'
            }
          },
          startIndex: {
            required: true,
            serializedName: 'startIndex',
            type: {
              name: 'Number'
            }
          },
          endIndex: {
            required: true,
            serializedName: 'endIndex',
            type: {
              name: 'Number'
            }
          },
          resolution: {
            required: false,
            serializedName: 'resolution',
            type: {
              name: 'Object'
            }
          }
        }
      }
    };
  }
}

module.exports = EntityWithResolution;
