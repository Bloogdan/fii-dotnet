using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Web;

namespace MyServiceBehaviors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class ChangeCollectionTypeBehaviorAttribute : Attribute, IServiceBehavior, IDataContractSurrogate
    {
        #region IServiceBehavior Members
        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
            foreach (var endpoint in serviceDescription.Endpoints)
            {
                foreach (var operation in endpoint.Contract.Operations)
                {
                    var serializationBehavior = operation.Behaviors.Find<DataContractSerializerOperationBehavior>();
                    if (serializationBehavior == null)
                    {
                        serializationBehavior = new DataContractSerializerOperationBehavior(operation);
                        operation.Behaviors.Add(serializationBehavior);
                    }
                    serializationBehavior.DataContractSurrogate = this;
                }
            }
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            // DO Nothing
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            // DO Nothing
        }
        #endregion IServiceBehavior Members


        public object GetCustomDataToExport(Type clrType, Type dataContractType)
        {
            return null;
        }

        public object GetCustomDataToExport(System.Reflection.MemberInfo memberInfo, Type dataContractType)
        {
            return null;
        }

        public Type GetDataContractType(Type type)
        {
            // Changes the IList<T> to List<T>
            if (type.IsGenericType && !type.IsGenericTypeDefinition && type.GetGenericTypeDefinition() == typeof(IList<>))
            {
                return typeof(List<>).MakeGenericType(type.GetGenericArguments()[0]);
            }
            return type;
        }

        public object GetDeserializedObject(object obj, Type targetType)
        {
            return obj;
        }

        public void GetKnownCustomDataTypes(Collection<Type> customDataTypes)
        {

        }

        public object GetObjectToSerialize(object obj, Type targetType)
        {
            return obj;
        }

        public Type GetReferencedTypeOnImport(string typeName, string typeNamespace, object customData)
        {
            return null;
        }

        public CodeTypeDeclaration ProcessImportedType(CodeTypeDeclaration typeDeclaration, CodeCompileUnit compileUnit)
        {
            return null;
        }
    }
}